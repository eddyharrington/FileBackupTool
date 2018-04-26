using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileBackupTool;

namespace FileBackupTool.Tests
{
    [TestClass]
    public class BackupSettingsTest
    {
        [TestMethod]
        public void DirectoryExists()
        {
            string backupName = "TestBackup";
            string backupDescription = "This is a test description for the backup.";
            string sourceDirectory = "C:\\Temp";
            string destinationDirectory = "C:\\Temp";

            BackupSettings newBackupSettings = new BackupSettings(backupName, backupDescription, sourceDirectory,
                destinationDirectory);
            newBackupSettings.ValidateFolderPaths(sourceDirectory);
            newBackupSettings.ValidateFolderPaths(destinationDirectory);
        }
    }
}
