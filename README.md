# File Backup Tool
This C# tool allows you to backup files and directories.

![Image of File Backup Tool](https://github.com/MrEdWORD/FileBackupTool/blob/master/ToolScreenshot.png)

## Instructions
1. Navigate to the [repo](https://github.com/MrEdWORD/FileBackupTool)
1. Clone or download the repo locally
1. Build the solution in Visual Studio
1. Enter a descriptive backup name
1. Enter the backup destination by typing in the folder path or using the Browse button
1. Enter the backup source by typing in the folder path or using the Browse button
1. Click the Backup! button to start the backup
1. Be amazed or disappointed, you decide :)

## Discussion
My goal was to create an application that lets you select a file or directory and then choose another directory/device to copy it to copy it to a new destination, and then eventually expand on that with more features such as scheduling automatic backups. Because this was just a learning exercise I decided to move on to the next project after the MVP was achieved (i.e. copy X from A to B).

I will revisit this repo and pickup from where I left off in the dev branch sometime in the future.

## TODO
 * Finish writing tests and feel bad this wasn't done first
 * Profile / configuration saving and loading
 * Schedule automatic backups
 * Improve the backup success / failure messaging and reporting
 * Pause, resume, and stop functionality during backup
