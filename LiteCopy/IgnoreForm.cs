using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteCopy
{
	partial class IgnoreForm : Form
	{
		public string IgnoredText { get; set; } = "";

		public IgnoreForm()
		{
			InitializeComponent();
		}

		private void IgnoreForm_Load(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(IgnoredText))
			{
				textBox1.Text = IgnoredText;
			}			
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string text = textBox1.Text.Trim();
			if (IgnoredText.Trim().Replace("\r\n", "") == text.Replace("\r\n", ""))
			{
				DialogResult = DialogResult.Cancel;
			}
			else
			{
				IgnoredText = text;
				DialogResult = DialogResult.OK;
			}						
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnDefault_Click(object sender, EventArgs e)
		{
			textBox1.Text = IgnoreManager.DefaultText;
		}
	}
}
