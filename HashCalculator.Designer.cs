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
            this.tbHashValue = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnCalculateSha1 = new System.Windows.Forms.Button();
            this.tbHashCheck = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            btnCalculateMd5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculateMd5
            // 
            btnCalculateMd5.Location = new System.Drawing.Point(278, 62);
            btnCalculateMd5.Name = "btnCalculateMd5";
            btnCalculateMd5.Size = new System.Drawing.Size(100, 23);
            btnCalculateMd5.TabIndex = 2;
            btnCalculateMd5.Text = "Calculate MD5";
            btnCalculateMd5.UseVisualStyleBackColor = true;
            btnCalculateMd5.Click += new System.EventHandler(this.btnCalculateMd5_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(12, 38);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(260, 20);
            this.tbFileName.TabIndex = 0;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(278, 38);
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
            // tbHashValue
            // 
            this.tbHashValue.Location = new System.Drawing.Point(12, 64);
            this.tbHashValue.Name = "tbHashValue";
            this.tbHashValue.ReadOnly = true;
            this.tbHashValue.Size = new System.Drawing.Size(260, 20);
            this.tbHashValue.TabIndex = 3;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Enabled = false;
            this.btnSelectFolder.Location = new System.Drawing.Point(383, 38);
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
            this.btnCalculateSha1.Location = new System.Drawing.Point(383, 61);
            this.btnCalculateSha1.Name = "btnCalculateSha1";
            this.btnCalculateSha1.Size = new System.Drawing.Size(100, 23);
            this.btnCalculateSha1.TabIndex = 5;
            this.btnCalculateSha1.Text = "Calculate SHA1";
            this.btnCalculateSha1.UseVisualStyleBackColor = true;
            this.btnCalculateSha1.Click += new System.EventHandler(this.btnCalculateSha1_Click);
            // 
            // tbHashCheck
            // 
            this.tbHashCheck.Location = new System.Drawing.Point(12, 91);
            this.tbHashCheck.Name = "tbHashCheck";
            this.tbHashCheck.Size = new System.Drawing.Size(260, 20);
            this.tbHashCheck.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
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
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(279, 91);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 24);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HashCalculator
            // 
            this.AcceptButton = btnCalculateMd5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 131);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbHashCheck);
            this.Controls.Add(this.btnCalculateSha1);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.tbHashValue);
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
        private System.Windows.Forms.TextBox tbHashValue;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnCalculateSha1;
        private System.Windows.Forms.TextBox tbHashCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Label lblStatus;

    }
}

