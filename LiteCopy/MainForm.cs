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
using ToolkitForms;
using Win32API;

namespace LiteCopy
{
	public partial class MainForm : Form
	{
		const string DefaultIgnores = ".vs/\r\nbin/\r\ndebug/\r\nrelease/\r\npackages/\r\nobj/\r\nnode_modules/\r\n#.git/\r\n#.gitattributes\r\n#.gitignore";
		static readonly string IgnoresFile = AppDomain.CurrentDomain.BaseDirectory + "Ignores.txt";
		string m_srcFolder;
		string m_destFolder;
		LiteCopyParser m_lcp = new LiteCopyParser();

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				txtIgnores.Text = File.ReadAllText(IgnoresFile);
			}
			catch
			{
				txtIgnores.Text = DefaultIgnores;
			}

			RegistryHelper reg = new RegistryHelper();
			reg.Open("Abin", ProductName, false);
			txtSrcFolder.Text = reg.ReadString("Source Folder");
			txtDestFolder.Text = reg.ReadString("Destination Folder");
			reg.Close();
		}

		private void btnBrowseSrc_Click(object sender, EventArgs e)
		{
			BrowseForFolder(txtSrcFolder);
		}

		private void btnBrowseDest_Click(object sender, EventArgs e)
		{
			BrowseForFolder(txtDestFolder);
		}

		private void BrowseForFolder(TextBox tb)
		{
			OpenFolderDialog dlg = new OpenFolderDialog();			
			dlg.SelectedPath = tb.Text;
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				tb.Text = dlg.SelectedPath;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			m_srcFolder = txtSrcFolder.Text.Trim();
			if (m_srcFolder == "" || !Directory.Exists(m_srcFolder))
			{
				MessageForm.Error(this, "Invalid source folder.");
				txtSrcFolder.Focus();
				txtSrcFolder.SelectAll();
				return;
			}

			m_destFolder = txtDestFolder.Text.Trim();
			if (m_destFolder == "" || !Directory.Exists(m_destFolder))
			{
				MessageForm.Error(this, "Invalid destination folder.");
				txtDestFolder.Focus();
				txtDestFolder.SelectAll();
				return;
			}

			RegistryHelper reg = new RegistryHelper();
			reg.Open("Abin", ProductName, true);
			reg.WriteString("Source Folder", txtSrcFolder.Text);
			reg.WriteString("Destination Folder", txtDestFolder.Text);
			reg.Close();

			SaveIgnoresFile();

			TaskForm form = new TaskForm();
			form.Message = "Preparing for files...";
			form.AllowAbort = false;
			form.TaskProc = PrepareFiles;

			if (form.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}

			int error = SHFileOperation.Copy(m_lcp.SrcFiles, m_lcp.DestFiles);
			if (error == 0)
			{
				MessageForm.Info(this, "Copy completed successfully.");
			}
			else
			{
				MessageForm.Error(this, "Copy failed: " + SHFileOperation.GetErrorString(error));
			}
		}

		private void SaveIgnoresFile()
		{
			try
			{
				File.WriteAllText(IgnoresFile, txtIgnores.Text);
			}
			catch (Exception ex)
			{
				MessageForm.Warning(this, ex.Message);
			}
		}

		private void PrepareFiles()
		{
			m_lcp.Start(m_srcFolder, m_destFolder, txtIgnores.Text);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnDefault_Click(object sender, EventArgs e)
		{
			if (MessageForm.Show(this, "Restore default ignored items, are you sure?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				txtIgnores.Text = DefaultIgnores;
				SaveIgnoresFile();
			}
		}
	}
}
