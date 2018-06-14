using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileBackupTool
{
    public class Backup
    {
        private BackupSettings BackupSetting { get; set; }
        public int TotalFiles; //TODO should use _namingConvention since they are class level variables
        public int CopiedFiles;
        public int CopiedDirectories;

        public Backup(BackupSettings backupSetting)
        {
            BackupSetting = backupSetting;
        }

        public void BackupFiles()
        {
            string backupName = BackupSetting.Name;
            string backupSourceDirectory = BackupSetting.SourceDirectory;
            string backupDestinationDirectory = BackupSetting.DestinationDirectory;
            bool copySubDirs = true;

            //Dont need to check if directories are valid due to that being done on the form
            //Count all files in source directory
            TotalFiles = Directory.GetFiles(backupSourceDirectory, "*", SearchOption.AllDirectories).Length;
            //Copy all files in directory - loop through file by file, update copied files w/ each success
            DirectoryCopy(backupSourceDirectory, backupDestinationDirectory, copySubDirs);
        }

        private void DirectoryCopy(string backupSourceDirectory, string backupDestinationDirectory, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(backupSourceDirectory);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + backupSourceDirectory);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(backupDestinationDirectory))
            {
                Directory.CreateDirectory(backupDestinationDirectory);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(backupDestinationDirectory, file.Name);
                file.CopyTo(temppath, false);
                CopiedFiles++;
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(backupDestinationDirectory, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                    CopiedDirectories++;
                }
            }
        }
    }
}
