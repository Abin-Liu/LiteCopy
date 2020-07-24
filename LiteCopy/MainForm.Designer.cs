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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSrcFolder = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDestFolder = new System.Windows.Forms.TextBox();
			this.txtIgnores = new System.Windows.Forms.TextBox();
			this.btnDefault = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnBrowseDest = new System.Windows.Forms.Button();
			this.btnBrowseSrc = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ignored items:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 234);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "Source folder:";
			// 
			// txtSrcFolder
			// 
			this.txtSrcFolder.Location = new System.Drawing.Point(14, 249);
			this.txtSrcFolder.Name = "txtSrcFolder";
			this.txtSrcFolder.Size = new System.Drawing.Size(342, 21);
			this.txtSrcFolder.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 281);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "Destination folder:";
			// 
			// txtDestFolder
			// 
			this.txtDestFolder.Location = new System.Drawing.Point(14, 296);
			this.txtDestFolder.Name = "txtDestFolder";
			this.txtDestFolder.Size = new System.Drawing.Size(342, 21);
			this.txtDestFolder.TabIndex = 5;
			// 
			// txtIgnores
			// 
			this.txtIgnores.AcceptsReturn = true;
			this.txtIgnores.Location = new System.Drawing.Point(14, 44);
			this.txtIgnores.Multiline = true;
			this.txtIgnores.Name = "txtIgnores";
			this.txtIgnores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtIgnores.Size = new System.Drawing.Size(374, 176);
			this.txtIgnores.TabIndex = 9;
			// 
			// btnDefault
			// 
			this.btnDefault.Image = global::LiteCopy.Properties.Resources.Default;
			this.btnDefault.Location = new System.Drawing.Point(308, 12);
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.Size = new System.Drawing.Size(80, 26);
			this.btnDefault.TabIndex = 10;
			this.btnDefault.Text = " Default";
			this.btnDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDefault.UseVisualStyleBackColor = true;
			this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Image = global::LiteCopy.Properties.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(228, 335);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 26);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = " Exit";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Image = global::LiteCopy.Properties.Resources.OK;
			this.btnOK.Location = new System.Drawing.Point(97, 335);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(80, 26);
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = " Copy";
			this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnBrowseDest
			// 
			this.btnBrowseDest.Image = global::LiteCopy.Properties.Resources.Browse;
			this.btnBrowseDest.Location = new System.Drawing.Point(362, 294);
			this.btnBrowseDest.Name = "btnBrowseDest";
			this.btnBrowseDest.Size = new System.Drawing.Size(26, 24);
			this.btnBrowseDest.TabIndex = 6;
			this.btnBrowseDest.UseVisualStyleBackColor = true;
			this.btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);
			// 
			// btnBrowseSrc
			// 
			this.btnBrowseSrc.Image = global::LiteCopy.Properties.Resources.Browse;
			this.btnBrowseSrc.Location = new System.Drawing.Point(362, 247);
			this.btnBrowseSrc.Name = "btnBrowseSrc";
			this.btnBrowseSrc.Size = new System.Drawing.Size(26, 24);
			this.btnBrowseSrc.TabIndex = 3;
			this.btnBrowseSrc.UseVisualStyleBackColor = true;
			this.btnBrowseSrc.Click += new System.EventHandler(this.btnBrowseSrc_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 380);
			this.Controls.Add(this.btnDefault);
			this.Controls.Add(this.txtIgnores);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnBrowseDest);
			this.Controls.Add(this.txtDestFolder);
			this.Controls.Add(this.btnBrowseSrc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSrcFolder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LiteCopy";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSrcFolder;
		private System.Windows.Forms.Button btnBrowseSrc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDestFolder;
		private System.Windows.Forms.Button btnBrowseDest;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtIgnores;
		private System.Windows.Forms.Button btnDefault;
	}
}

