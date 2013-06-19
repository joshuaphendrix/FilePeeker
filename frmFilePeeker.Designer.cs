namespace FilePeeker
{
    partial class frmFilePeeker
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBytes = new System.Windows.Forms.TextBox();
            this.chkListFileAttributes = new System.Windows.Forms.CheckedListBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPeek = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLastWriteTime = new System.Windows.Forms.TextBox();
            this.txtLastAccessTime = new System.Windows.Forms.TextBox();
            this.txtCreationTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.encryptionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptFileToolStripMenuItem,
            this.decryptFileToolStripMenuItem});
            this.encryptionToolStripMenuItem.Enabled = false;
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.encryptionToolStripMenuItem.Text = "&Encryption";
            // 
            // encryptFileToolStripMenuItem
            // 
            this.encryptFileToolStripMenuItem.Name = "encryptFileToolStripMenuItem";
            this.encryptFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.encryptFileToolStripMenuItem.Text = "&Encrypt File";
            this.encryptFileToolStripMenuItem.Click += new System.EventHandler(this.encryptFileToolStripMenuItem_Click);
            // 
            // decryptFileToolStripMenuItem
            // 
            this.decryptFileToolStripMenuItem.Name = "decryptFileToolStripMenuItem";
            this.decryptFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decryptFileToolStripMenuItem.Text = "&Decrypt File";
            this.decryptFileToolStripMenuItem.Click += new System.EventHandler(this.decryptFileToolStripMenuItem_Click);
            // 
            // txtText
            // 
            this.txtText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtText.BackColor = System.Drawing.SystemColors.Window;
            this.txtText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(269, 93);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtText.Size = new System.Drawing.Size(458, 165);
            this.txtText.TabIndex = 1;
            this.txtText.WordWrap = false;
            this.txtText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyUp);
            this.txtText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtText_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // txtBytes
            // 
            this.txtBytes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBytes.Location = new System.Drawing.Point(308, 47);
            this.txtBytes.Name = "txtBytes";
            this.txtBytes.Size = new System.Drawing.Size(61, 13);
            this.txtBytes.TabIndex = 4;
            // 
            // chkListFileAttributes
            // 
            this.chkListFileAttributes.FormattingEnabled = true;
            this.chkListFileAttributes.Location = new System.Drawing.Point(8, 80);
            this.chkListFileAttributes.Name = "chkListFileAttributes";
            this.chkListFileAttributes.Size = new System.Drawing.Size(233, 109);
            this.chkListFileAttributes.TabIndex = 6;
            // 
            // txtStart
            // 
            this.txtStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStart.Location = new System.Drawing.Point(308, 31);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(61, 13);
            this.txtStart.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bytes:";
            // 
            // btnPeek
            // 
            this.btnPeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeek.Location = new System.Drawing.Point(274, 66);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(95, 21);
            this.btnPeek.TabIndex = 9;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtLastWriteTime);
            this.panel1.Controls.Add(this.txtLastAccessTime);
            this.panel1.Controls.Add(this.txtCreationTime);
            this.panel1.Controls.Add(this.chkListFileAttributes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 231);
            this.panel1.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(132, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Update Attributes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLastWriteTime
            // 
            this.txtLastWriteTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastWriteTime.Location = new System.Drawing.Point(100, 59);
            this.txtLastWriteTime.Name = "txtLastWriteTime";
            this.txtLastWriteTime.Size = new System.Drawing.Size(141, 13);
            this.txtLastWriteTime.TabIndex = 13;
            // 
            // txtLastAccessTime
            // 
            this.txtLastAccessTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastAccessTime.Location = new System.Drawing.Point(100, 36);
            this.txtLastAccessTime.Name = "txtLastAccessTime";
            this.txtLastAccessTime.Size = new System.Drawing.Size(141, 13);
            this.txtLastAccessTime.TabIndex = 12;
            // 
            // txtCreationTime
            // 
            this.txtCreationTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreationTime.Location = new System.Drawing.Point(100, 13);
            this.txtCreationTime.Name = "txtCreationTime";
            this.txtCreationTime.Size = new System.Drawing.Size(141, 13);
            this.txtCreationTime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Last Write Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Access Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Creation time:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 261);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(727, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPosition
            // 
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 17);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // frmFilePeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 283);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtBytes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFilePeeker";
            this.Text = "File Peeker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBytes;
        private System.Windows.Forms.CheckedListBox chkListFileAttributes;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastWriteTime;
        private System.Windows.Forms.TextBox txtLastAccessTime;
        private System.Windows.Forms.TextBox txtCreationTime;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptFileToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblPosition;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

