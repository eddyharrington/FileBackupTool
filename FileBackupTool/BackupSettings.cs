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
        public string Name { get; set; }
        public string DestinationDirectory { get; set; }
        public string SourceDirectory { get; set; }

        public BackupSettings(string name, string destinationDirectory, string sourceDirectory)
        {
            Name = name;
            DestinationDirectory = destinationDirectory;
            SourceDirectory = sourceDirectory;
        }
    }
}
