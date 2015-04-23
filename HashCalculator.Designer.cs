namespace HashCalculator
{
    partial class HashCalculator
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
            System.Windows.Forms.Button btnCalculateMd5;
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbMD5HashValue = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnCalculateSha1 = new System.Windows.Forms.Button();
            this.tbMD5HashCheck = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMD5Status = new System.Windows.Forms.Label();
            this.tbSHA1HashValue = new System.Windows.Forms.TextBox();
            this.tbSHA1HashCheck = new System.Windows.Forms.TextBox();
            this.lblSHA1Status = new System.Windows.Forms.Label();
            btnCalculateMd5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculateMd5
            // 
            btnCalculateMd5.Location = new System.Drawing.Point(276, 97);
            btnCalculateMd5.Name = "btnCalculateMd5";
            btnCalculateMd5.Size = new System.Drawing.Size(100, 23);
            btnCalculateMd5.TabIndex = 2;
            btnCalculateMd5.Text = "Calculate MD5";
            btnCalculateMd5.UseVisualStyleBackColor = true;
            btnCalculateMd5.Click += new System.EventHandler(this.btnCalculateMd5_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.AllowDrop = true;
            this.tbFileName.Location = new System.Drawing.Point(12, 38);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(419, 20);
            this.tbFileName.TabIndex = 0;
            this.tbFileName.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFileName_DragDrop);
            this.tbFileName.DragOver += new System.Windows.Forms.DragEventHandler(this.tbFileName_DragOver);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(437, 35);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(100, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbMD5HashValue
            // 
            this.tbMD5HashValue.Location = new System.Drawing.Point(10, 153);
            this.tbMD5HashValue.Name = "tbMD5HashValue";
            this.tbMD5HashValue.ReadOnly = true;
            this.tbMD5HashValue.Size = new System.Drawing.Size(260, 20);
            this.tbMD5HashValue.TabIndex = 3;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Enabled = false;
            this.btnSelectFolder.Location = new System.Drawing.Point(542, 35);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(100, 23);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Visible = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnCalculateSha1
            // 
            this.btnCalculateSha1.Location = new System.Drawing.Point(381, 96);
            this.btnCalculateSha1.Name = "btnCalculateSha1";
            this.btnCalculateSha1.Size = new System.Drawing.Size(100, 23);
            this.btnCalculateSha1.TabIndex = 5;
            this.btnCalculateSha1.Text = "Calculate SHA1";
            this.btnCalculateSha1.UseVisualStyleBackColor = true;
            this.btnCalculateSha1.Click += new System.EventHandler(this.btnCalculateSha1_Click);
            // 
            // tbMD5HashCheck
            // 
            this.tbMD5HashCheck.Location = new System.Drawing.Point(276, 153);
            this.tbMD5HashCheck.Name = "tbMD5HashCheck";
            this.tbMD5HashCheck.Size = new System.Drawing.Size(260, 20);
            this.tbMD5HashCheck.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(92, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(194, 22);
            this.tsmiAbout.Text = "About Hash Calculator";
            // 
            // lblMD5Status
            // 
            this.lblMD5Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMD5Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMD5Status.Location = new System.Drawing.Point(542, 153);
            this.lblMD5Status.Name = "lblMD5Status";
            this.lblMD5Status.Size = new System.Drawing.Size(100, 20);
            this.lblMD5Status.TabIndex = 8;
            this.lblMD5Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSHA1HashValue
            // 
            this.tbSHA1HashValue.Location = new System.Drawing.Point(10, 179);
            this.tbSHA1HashValue.Name = "tbSHA1HashValue";
            this.tbSHA1HashValue.ReadOnly = true;
            this.tbSHA1HashValue.Size = new System.Drawing.Size(260, 20);
            this.tbSHA1HashValue.TabIndex = 9;
            // 
            // tbSHA1HashCheck
            // 
            this.tbSHA1HashCheck.Location = new System.Drawing.Point(276, 179);
            this.tbSHA1HashCheck.Name = "tbSHA1HashCheck";
            this.tbSHA1HashCheck.Size = new System.Drawing.Size(260, 20);
            this.tbSHA1HashCheck.TabIndex = 10;
            // 
            // lblSHA1Status
            // 
            this.lblSHA1Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSHA1Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHA1Status.Location = new System.Drawing.Point(542, 178);
            this.lblSHA1Status.Name = "lblSHA1Status";
            this.lblSHA1Status.Size = new System.Drawing.Size(100, 20);
            this.lblSHA1Status.TabIndex = 11;
            this.lblSHA1Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HashCalculator
            // 
            this.AcceptButton = btnCalculateMd5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 260);
            this.Controls.Add(this.lblSHA1Status);
            this.Controls.Add(this.tbSHA1HashCheck);
            this.Controls.Add(this.tbSHA1HashValue);
            this.Controls.Add(this.lblMD5Status);
            this.Controls.Add(this.tbMD5HashCheck);
            this.Controls.Add(this.btnCalculateSha1);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.tbMD5HashValue);
            this.Controls.Add(btnCalculateMd5);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HashCalculator";
            this.ShowIcon = false;
            this.Text = "Simple Hash Calculator";
            this.Load += new System.EventHandler(this.HashCalculator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbMD5HashValue;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnCalculateSha1;
        private System.Windows.Forms.TextBox tbMD5HashCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Label lblMD5Status;
        private System.Windows.Forms.TextBox tbSHA1HashValue;
        private System.Windows.Forms.TextBox tbSHA1HashCheck;
        private System.Windows.Forms.Label lblSHA1Status;

    }
}

