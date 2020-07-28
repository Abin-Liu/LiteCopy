namespace LiteCopy
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDestFolder = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteSelectedItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnBrowseDest = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkVisualStudio = new System.Windows.Forms.CheckBox();
			this.chkNodeJS = new System.Windows.Forms.CheckBox();
			this.chkGit = new System.Windows.Forms.CheckBox();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Source folders:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Destination folder:";
			// 
			// txtDestFolder
			// 
			this.txtDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDestFolder.Location = new System.Drawing.Point(12, 241);
			this.txtDestFolder.Name = "txtDestFolder";
			this.txtDestFolder.Size = new System.Drawing.Size(469, 20);
			this.txtDestFolder.TabIndex = 3;
			// 
			// listView1
			// 
			this.listView1.AllowDrop = true;
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 26);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(503, 182);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.List;
			this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
			this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteSelectedItemsToolStripMenuItem,
            this.clearAllToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(119, 70);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.addToolStripMenuItem.Text = "Add...";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// deleteSelectedItemsToolStripMenuItem
			// 
			this.deleteSelectedItemsToolStripMenuItem.Name = "deleteSelectedItemsToolStripMenuItem";
			this.deleteSelectedItemsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.deleteSelectedItemsToolStripMenuItem.Text = "Delete";
			this.deleteSelectedItemsToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedItemsToolStripMenuItem_Click);
			// 
			// clearAllToolStripMenuItem
			// 
			this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
			this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.clearAllToolStripMenuItem.Text = "Clear All";
			this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Folder_Small.png");
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.Image = global::LiteCopy.Properties.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(304, 358);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(91, 28);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "  Exit";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnOK.Image = global::LiteCopy.Properties.Resources.OK;
			this.btnOK.Location = new System.Drawing.Point(136, 358);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(91, 28);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "  Copy";
			this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnBrowseDest
			// 
			this.btnBrowseDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseDest.Image = global::LiteCopy.Properties.Resources.Browse;
			this.btnBrowseDest.Location = new System.Drawing.Point(487, 238);
			this.btnBrowseDest.Name = "btnBrowseDest";
			this.btnBrowseDest.Size = new System.Drawing.Size(26, 26);
			this.btnBrowseDest.TabIndex = 4;
			this.btnBrowseDest.UseVisualStyleBackColor = true;
			this.btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.chkGit);
			this.groupBox1.Controls.Add(this.chkNodeJS);
			this.groupBox1.Controls.Add(this.chkVisualStudio);
			this.groupBox1.Location = new System.Drawing.Point(12, 276);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(501, 61);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ignores";
			// 
			// chkVisualStudio
			// 
			this.chkVisualStudio.AutoSize = true;
			this.chkVisualStudio.Location = new System.Drawing.Point(19, 26);
			this.chkVisualStudio.Name = "chkVisualStudio";
			this.chkVisualStudio.Size = new System.Drawing.Size(87, 17);
			this.chkVisualStudio.TabIndex = 0;
			this.chkVisualStudio.Text = "Visual Studio";
			this.chkVisualStudio.UseVisualStyleBackColor = true;
			// 
			// chkNodeJS
			// 
			this.chkNodeJS.AutoSize = true;
			this.chkNodeJS.Location = new System.Drawing.Point(160, 26);
			this.chkNodeJS.Name = "chkNodeJS";
			this.chkNodeJS.Size = new System.Drawing.Size(67, 17);
			this.chkNodeJS.TabIndex = 1;
			this.chkNodeJS.Text = "Node JS";
			this.chkNodeJS.UseVisualStyleBackColor = true;
			// 
			// chkGit
			// 
			this.chkGit.AutoSize = true;
			this.chkGit.Location = new System.Drawing.Point(292, 26);
			this.chkGit.Name = "chkGit";
			this.chkGit.Size = new System.Drawing.Size(39, 17);
			this.chkGit.TabIndex = 2;
			this.chkGit.Text = "Git";
			this.chkGit.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 403);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnBrowseDest);
			this.Controls.Add(this.txtDestFolder);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LiteCopy";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDestFolder;
		private System.Windows.Forms.Button btnBrowseDest;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteSelectedItemsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkGit;
		private System.Windows.Forms.CheckBox chkNodeJS;
		private System.Windows.Forms.CheckBox chkVisualStudio;
	}
}

