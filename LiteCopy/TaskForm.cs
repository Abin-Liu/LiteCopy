using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteCopy
{
	partial class TaskForm : Form
	{
		public ThreadStart TaskProc { get; set; }
		public string Error { get; private set; }
		public bool Success { get; private set; }

		Thread m_thread = null;

		public TaskForm()
		{
			InitializeComponent();
		}

		private void TaskForm_Load(object sender, EventArgs e)
		{
			Success = false;
			Error = null;

			m_thread = new Thread(ThreadProc);
			m_thread.IsBackground = true;
			m_thread.Start();
			timer1.Enabled = true;
		}

		private void ThreadProc()
		{
			try
			{
				TaskProc?.Invoke();
				Success = true;
			}
			catch (Exception e)
			{
				Error = e.Message;
				Success = false;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (m_thread.IsAlive)			
			{
				return;
			}

			timer1.Enabled = false;
			DialogResult = Success ? DialogResult.OK : DialogResult.Cancel;
		}
	}
}
