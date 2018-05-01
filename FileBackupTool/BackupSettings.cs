using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBackupTool
{
    public class BackupSettings
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private string SourceDirectory { get; set; }
        private string DestinationDirectory { get; set; }

        public BackupSettings(string name, string description, string sourceDirectory, string destinationDirectory)
        {
            Name = name;
            Description = description;
            SourceDirectory = ValidateFolderPaths(sourceDirectory);
            DestinationDirectory = ValidateFolderPaths(destinationDirectory);
        }

        public string ValidateFolderPaths(string folderPath)
        {

            //Don't allow null or empty strings as folder paths
            if (string.IsNullOrWhiteSpace(folderPath))
            {
                throw new Exception("The folder path canont be null or empty");
            }
            //Don't allow non-existant folder paths
            else if (!Directory.Exists(folderPath))
            {
                throw new Exception("The folder path does not exist");
            }
            else
            {
                return folderPath;
            }
        }
    }
}
