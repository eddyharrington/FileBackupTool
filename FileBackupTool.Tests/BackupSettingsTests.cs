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
            string backupName = "Test_DirectoryExists";
            string backupDescription = "The purpose of this backup is for DirectoryExists test method.";
            string sourceDirectory = "C:\\Temp";
            string destinationDirectory = "C:\\Temp";

            BackupSettings newBackupSettings = new BackupSettings(backupName, backupDescription, sourceDirectory,
                destinationDirectory);
            newBackupSettings.ValidateFolderPaths(sourceDirectory);
            newBackupSettings.ValidateFolderPaths(destinationDirectory);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DirectoryDoesNotExist()
        {
            string backupName = "Test_DirectoryDoesNotExist";
            string backupDescription = "The purpose of this backup is for DirectoryDoesNotExist test method.";
            string sourceDirectory = "C:\\Temp\\ThereIsNoSpoon";
            string destinationDirectory = "Hello World!";

            BackupSettings newBackupSettings = new BackupSettings(backupName, backupDescription, sourceDirectory,
                destinationDirectory);
            newBackupSettings.ValidateFolderPaths(sourceDirectory);
            newBackupSettings.ValidateFolderPaths(destinationDirectory);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DirectoryIsNullOrEmpty()
        {
            string backupName = "Test_DirectoryDoesNotExist";
            string backupDescription = "The purpose of this backup is for DirectoryDoesNotExist test method.";
            string sourceDirectory = "";
            string destinationDirectory = null;

            BackupSettings newBackupSettings = new BackupSettings(backupName, backupDescription, sourceDirectory,
                destinationDirectory);
            newBackupSettings.ValidateFolderPaths(sourceDirectory);
            newBackupSettings.ValidateFolderPaths(destinationDirectory);
        }
    }
}
