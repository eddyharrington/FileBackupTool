using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBackupTool
{
    public partial class FormNewBackup : Form
    {
        public FormNewBackup()
        {
            InitializeComponent();
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
                lbBackupDirectories.Items.Add(folderPath);
            }
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

        private void btnStartBackup_Click(object sender, EventArgs e)
        {
            BackupSettings bs = new BackupSettings(txtBoxBackupName.Text, txtBoxBackupDescription.Text,
    txtBoxBackupFrom.Text, txtBoxBackupTo.Text);
        }
    }
}
