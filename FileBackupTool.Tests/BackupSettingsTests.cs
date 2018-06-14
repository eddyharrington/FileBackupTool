using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.IO;
using FileBackupTool;

namespace FileBackupTool.Tests
{
    [TestClass]
    public class BackupSettingsTest
    {

        [TestMethod]
        public void CopyFolder()
        {
            //Set working path for test data
            Assembly ass = Assembly.GetExecutingAssembly();
            string buildPath = System.IO.Path.GetDirectoryName(ass.Location);
            string expectedTestDataPath = Path.Combine(buildPath, "Test Data");

            CreateTestData();
            //Tests
            string backupName = "Test_CopyFolder";
            string destinationDirectory = Path.Combine(expectedTestDataPath, "Backup Destination");
            string sourceDirectory = Path.Combine(expectedTestDataPath, "Backup Source");
            BackupSettings bs = new BackupSettings(backupName, destinationDirectory, sourceDirectory);
            Backup b = new Backup(bs);
            b.BackupFiles();
            //Actual vs Expected assert

            DeleteTestData();

        }

        private void DeleteTestData()
        {
            //Set working path for test data
            Assembly ass = Assembly.GetExecutingAssembly();
            string buildPath = System.IO.Path.GetDirectoryName(ass.Location);
            string testDataPath = Path.Combine(buildPath, "Test Data");

            //Delete directory if it exists
            DirectoryInfo dir = new DirectoryInfo(testDataPath);
            if (dir.Exists)
            {
                Directory.Delete(testDataPath, true);
            }
        }

        public void CreateTestData()
        {
            //Set working path for test data
            Assembly ass = Assembly.GetExecutingAssembly();
            string buildPath = System.IO.Path.GetDirectoryName(ass.Location);
            string testDataPath = Path.Combine(buildPath, "Test Data");

            //Create directory if it doesn't exist
            DirectoryInfo dir = new DirectoryInfo(testDataPath);
            if (!dir.Exists)
            {
                //Create test data directory
                Directory.CreateDirectory(testDataPath);
                //Create sub-directories
                Directory.CreateDirectory(Path.Combine(testDataPath, "Backup Destination"));
                testDataPath = Path.Combine(testDataPath, "Backup Source");
                Directory.CreateDirectory(testDataPath);
                Directory.CreateDirectory(Path.Combine(testDataPath, "Random Junk"));
                //Create files in source sub-directories
                string fileName = "MyNewFile.txt";
                testDataPath = Path.Combine(testDataPath, fileName);
                //Check that the file doesn't already exist. If it doesn't, create it.
                if (!File.Exists(testDataPath))
                {
                    using (FileStream fs = File.Create(testDataPath))
                    {
                        for (byte i = 0; i < 100; i++)
                        {
                            fs.WriteByte(i);
                        }
                    }
                }

                DirectoryInfo[] dirs = dir.GetDirectories();
                for (int i = 0; i < 25; i++)
                {
                    string junkDataPath = Path.Combine(dirs[1].FullName, "Random Junk");
                    string randomFileName = Path.GetRandomFileName();
                    junkDataPath = Path.Combine(junkDataPath, randomFileName);
                    using (FileStream fs = File.Create(junkDataPath))
                    {
                        for (byte ii = 0; ii < 100; ii++)
                        {
                            fs.WriteByte(ii);
                        }
                    }
                }
            }
        }
    }
}
