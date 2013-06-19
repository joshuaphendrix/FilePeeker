using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace FilePeeker
{
    public partial class frmFilePeeker : Form
    {

        private int start;
        private int count;
        public frmFilePeeker()
        {
            InitializeComponent();
            this.txtStart.Text = "0";
            txtBytes.Text = "500";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileOk += new CancelEventHandler(openFileDialog1_FileOk);
            openFileDialog1.ShowDialog();
        }

        private void getFileInfo(FileInfo fi)
        {
            this.Text = fi.FullName + " (" +fi.Length.ToString("#,###") + ")";

            this.chkListFileAttributes.Items.Clear();
            foreach(Enum e in Enum.GetValues(typeof(FileAttributes)))
            {
                this.chkListFileAttributes.Items.Add(e,fi.Attributes.ToString().Contains(e.ToString()));
            }

            this.txtCreationTime.Text = fi.CreationTime.ToString();
            this.txtLastAccessTime.Text = fi.LastAccessTime.ToString();
            this.txtLastWriteTime.Text = fi.LastWriteTime.ToString();
        }

        void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            getFileInfo(new FileInfo(openFileDialog1.FileName));
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            start = Int32.Parse(this.txtStart.Text);
            count = Int32.Parse(this.txtBytes.Text);

            char[] content = new char[0];

            FileInfo fi = new FileInfo(openFileDialog1.FileName);

            if(fi.Length <= start)
            {
                //There is no data starting at position
                return;
            }else if(fi.Length < (long)(start + count))
            {
                //Data out of range.  Returning positions {0} for {1} bytes",start,fi.Length-start);
                content = new char[fi.Length-start];
                count = ((int)fi.Length)-start;
            }else
            {
                content = new char[count];
            }

            try
            {
                using(StreamReader reader = fi.OpenText())
                {
                    reader.BaseStream.Seek(start,SeekOrigin.Begin);
                    reader.ReadBlock(content,0,count);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string s = new string(content);
            this.txtText.Text = s;
        }

        private void encryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(this.openFileDialog1.FileName);

            if(!fi.Exists)
            {
                MessageBox.Show("File Not Found");
                return;
            }

            if(fi.Attributes.ToString().Contains(FileAttributes.Encrypted.ToString()))
            {   
                MessageBox.Show("File is already encrypted");
                return;
            }

            if(MessageBox.Show("Are you sure you want to encrypt this file?\n\nOnly this user will be able to decrypt","File Peeker",MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                fi.IsReadOnly = false;

                try
                {
                    fi.Encrypt();
                    fi.Refresh();
                    getFileInfo(fi);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void decryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(this.openFileDialog1.FileName);

            if(!fi.Exists)
            {
                MessageBox.Show("File Not Found");
                return;
            }

            if(!fi.Attributes.ToString().Contains(FileAttributes.Encrypted.ToString()))
            {   
                MessageBox.Show("File is not encrypted");
                return;
            }

            fi.IsReadOnly = false;

            try
            {
                fi.Encrypt();
                fi.Refresh();
                getFileInfo(fi);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calcPosition()
        {
            int fileStart = start + this.txtText.SelectionStart;
            
            this.lblPosition.Text = String.Format("Position: {0:#,###}({1:#,###}),{2:#,###}",fileStart,this.txtText.SelectionStart,this.txtText.SelectionLength);
        }
        private void txtText_MouseUp(object sender, MouseEventArgs e)
        {
            calcPosition();
        }

        private void txtText_KeyUp(object sender, KeyEventArgs e)
        {
            calcPosition();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(this.openFileDialog1.FileName);
            FileAttributes fa = new FileAttributes();

            foreach(object o in this.chkListFileAttributes.CheckedItems)
            {
                fa = fa | (FileAttributes)(Enum)o;
            }

            try
            {
                if(fi.IsReadOnly) fi.IsReadOnly = false;
                fi.CreationTime = DateTime.Parse(this.txtCreationTime.Text);
                fi.LastAccessTime = DateTime.Parse(this.txtLastAccessTime.Text);
                fi.LastWriteTime = DateTime.Parse(this.txtLastWriteTime.Text);

                fi.Attributes = fa;
                getFileInfo(fi);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call Batman");
        }
    }
}