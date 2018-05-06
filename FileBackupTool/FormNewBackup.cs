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

namespace FileBackupTool
{
    public partial class FormNewBackup : Form
    {
        public FormNewBackup()
        {
            InitializeComponent();
        }

        private void btnBackupTo_Click(object sender, EventArgs e)
        {
            //Open folder browser dialog and let user choose the DESTINATION folder they want to backup to
            string folderPath = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog(); //TODO file extensions to exclude
            dialog.Description = "Select the destination folder";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderPath = dialog.SelectedPath;
                txtBoxBackupTo.Text = dialog.SelectedPath;
            }
        }

        private void btnBackupFrom_Click(object sender, EventArgs e)
        {
            //Open folder browser dialog and let user choose the SOURCE folder they want to backup from
            string folderPath = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog(); //TODO file extensions to exclude
            dialog.Description = "Select the source folder";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderPath = dialog.SelectedPath;
                txtBoxBackupFrom.Text = dialog.SelectedPath;
            }
        }

        private void btnStartBackup_Click(object sender, EventArgs e)
        {
            //Ensure backup name is provided
            if (txtBoxBackupName.Text == string.Empty)
            {
                MessageBox.Show("You must provide a backup name", "Backup Name is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Ensure destination directory exists
            else if (!Directory.Exists(txtBoxBackupTo.Text))
            {
                MessageBox.Show("You must provide a directory that exists", "Directory does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Ensure source directory exists
            else if (!Directory.Exists(txtBoxBackupFrom.Text))
            {
                MessageBox.Show("You must provide a directory that exists", "Directory does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Store settings and backup files
            else
            {
                BackupSettings bs = new BackupSettings(txtBoxBackupName.Text, txtBoxBackupTo.Text, txtBoxBackupFrom.Text);
                Backup b = new Backup(bs);
                b.BackupFiles();
                MessageBox.Show("Success! Total files in backup: "+ b.TotalFiles + " Total copied files: " 
                    + b.CopiedFiles + " Total copied dirs: " + b.CopiedDirectories, "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}