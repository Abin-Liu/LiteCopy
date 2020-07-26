using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MFGLib;
using Win32API;

namespace LiteCopy
{
	public partial class MainForm : Form
	{
		List<string> m_srcFolders = new List<string>();
		string m_destFolder = null;
		IgnoreManager m_im = new IgnoreManager();
		LiteCopyParser m_lcp = new LiteCopyParser();

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			RegistryHelper reg = new RegistryHelper();
			reg.Open("Abin", ProductName, false);
			txtDestFolder.Text = reg.ReadString("Destination Folder");
			reg.Close();

			m_im.Load();
			m_im.Parse();
		}		

		private void btnBrowseDest_Click(object sender, EventArgs e)
		{
			OpenFolderDialog dlg = new OpenFolderDialog();
			dlg.SelectedPath = txtDestFolder.Text;
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				txtDestFolder.Text = dlg.SelectedPath;
			}
		}		

		private void btnOK_Click(object sender, EventArgs e)
		{			
			if (m_srcFolders.Count == 0)
			{
				MessageBox.Show(this, "Please specify at least 1 source folder.", "LiteCopy", MessageBoxButtons.OK, MessageBoxIcon.Error);				
				return;
			}

			m_destFolder = txtDestFolder.Text.Trim();
			if (m_destFolder == "" || !Directory.Exists(m_destFolder))
			{
				MessageBox.Show(this, "Invalid destination folder.", "LiteCopy", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtDestFolder.Focus();
				txtDestFolder.SelectAll();
				return;
			}

			RegistryHelper reg = new RegistryHelper();
			reg.Open("Abin", ProductName, true);
			reg.WriteString("Destination Folder", txtDestFolder.Text);
			reg.Close();

			TaskForm form = new TaskForm();
			form.TaskProc = TaskProc;

			if (form.ShowDialog(this) == DialogResult.OK)
			{
				MessageBox.Show(this, "Copy completed successfully.", "LiteCopy", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show(this, form.Error, "LiteCopy", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}		

		private void TaskProc()
		{
			m_lcp.Parse(m_srcFolders, m_destFolder, m_im);
			int error = SHFileOperation.Copy(m_lcp.SrcFiles, m_lcp.DestFiles);
			m_lcp.Release(); // 可能包含几十万条字符串，及早释放
			if (error != 0)
			{
				throw new Exception("Copy failed: " + SHFileOperation.GetErrorString(error));
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnIgnores_Click(object sender, EventArgs e)
		{
			IgnoreForm form = new IgnoreForm();
			form.IgnoredText = m_im.Text;
			if (form.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			
			m_im.Text = form.IgnoredText;
			m_im.Parse();

			try
			{
				m_im.Save();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "LiteCopy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void listView1_DragEnter(object sender, DragEventArgs e)
		{
			if (!e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}

			Array array = e.Data.GetData(DataFormats.FileDrop) as Array;
			if (array == null || array.Length < 1)
			{
				return;
			}

			if (Directory.Exists(array.GetValue(0).ToString()))
			{
				e.Effect = DragDropEffects.Link;
			}
		}

		private void listView1_DragDrop(object sender, DragEventArgs e)
		{
			if (!e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}

			Array array = e.Data.GetData(DataFormats.FileDrop) as Array;
			if (array == null || array.Length < 1)
			{
				return;
			}

			listView1.BeginUpdate();
			for (int i = 0; i < array.Length; i++)
			{
				string folder = array.GetValue(i).ToString();
				if (m_srcFolders.IndexOf(folder) == -1)
				{
					m_srcFolders.Add(folder);
					listView1.Items.Add(folder, 0);
				}				
			}
			listView1.EndUpdate();
		}

		private void deleteSelectedItemsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListView.SelectedIndexCollection si = listView1.SelectedIndices;
			if (si.Count == 0)
			{
				return;
			}

			List<int> indices = new List<int>();
			foreach (int index in si)
			{
				indices.Add(index);
			}

			indices.Reverse();

			listView1.BeginUpdate();
			foreach (int index in indices)
			{
				m_srcFolders.RemoveAt(index);
				listView1.Items.RemoveAt(index);
			}
			listView1.EndUpdate();
		}

		private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_srcFolders.Clear();
			listView1.Items.Clear();
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFolderDialog dlg = new OpenFolderDialog();			
			if (dlg.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}

			string folder = dlg.SelectedPath;
			if (m_srcFolders.IndexOf(folder) == -1)
			{
				m_srcFolders.Add(folder);
				listView1.Items.Add(folder, 0);
			}
		}
	}
}
