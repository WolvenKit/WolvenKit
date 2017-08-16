using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace WolvenKit
{
    static class Commonfunctions
    {
        public static void SendNotification(string msg)
        {
            Version win8version = new Version(6, 2, 9200, 0);

            if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version >= win8version)
            {
                // its win8 or higher so we can use toas notifications TODO: Add actual rich toast notifications
                using (var ni = new NotifyIcon())
                {
                    ni.Icon = SystemIcons.Information;
                    ni.Visible = true;
                    ni.ShowBalloonTip(3000, "WolvenKit", msg, ToolTipIcon.Info);
                }

            }
            else
            {
                using (var ni = new NotifyIcon())
                {
                    ni.Icon = SystemIcons.Information;
                    ni.Visible = true;
                    ni.ShowBalloonTip(3000, "WolvenKit", msg, ToolTipIcon.Info);
                }
            }
        }

        public static void ShowWIPMessage()
        {
            MessageBox.Show("Work in progress.", "Coming soon(tm)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static void ShowFileInExplorer(string path)
        {
            Process.Start("explorer.exe", "/select, \"" + path + "\"");
        }

        public static XElement DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            XElement Root = new XElement("Copy");
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                Root.Add(new XElement("file", file.FullName));
                file.CopyTo(temppath, true);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    Root.Add(new XElement("Directory",new XAttribute("Path",temppath), DirectoryCopy(subdir.FullName, temppath, copySubDirs)));
                }
            }
            return Root;
        }

        public static void CompressFile(string filename, ZipOutputStream zipStream, string nameOverride = "")
        {
            FileInfo fi = new FileInfo(filename);

            string entryName = Path.GetFileName(filename);
            if (nameOverride != "")
                entryName = nameOverride;
            entryName = ZipEntry.CleanName(entryName);
            ZipEntry newEntry = new ZipEntry(entryName) { DateTime = fi.LastWriteTime, Size = fi.Length };
            zipStream.PutNextEntry(newEntry);
            byte[] buffer = new byte[4096];
            using (FileStream streamReader = File.OpenRead(filename))
            {
                StreamUtils.Copy(streamReader, zipStream, buffer);
            }
            zipStream.CloseEntry();
        }

        public static byte[] XDocToByteArray(XDocument xdoc)
        {
            MemoryStream ms = new MemoryStream();
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.OmitXmlDeclaration = true;
            xws.Indent = true;

            using (XmlWriter xw = XmlWriter.Create(ms, xws))
            {
                xdoc.WriteTo(xw);
            }
            return ms.ToArray();
        }

        public static void CompressStream(byte[] file, string filename, ZipOutputStream zipStream)
        {
            filename = ZipEntry.CleanName(filename);
            ZipEntry newEntry = new ZipEntry(filename) { DateTime = DateTime.Now, Size = file.Length };
            zipStream.PutNextEntry(newEntry);
            byte[] buffer = new byte[4096];
            StreamUtils.Copy(new MemoryStream(file), zipStream, buffer);
            zipStream.CloseEntry();
        }

        public static void CompressFolder(string path, ZipOutputStream zipStream, int folderOffset)
        {

            string[] files = Directory.GetFiles(path);

            foreach (string filename in files)
            {

                FileInfo fi = new FileInfo(filename);

                string entryName = filename.Substring(folderOffset);
                entryName = ZipEntry.CleanName(entryName);
                ZipEntry newEntry = new ZipEntry(entryName) { DateTime = fi.LastWriteTime, Size = fi.Length };
                zipStream.PutNextEntry(newEntry);
                byte[] buffer = new byte[4096];
                using (FileStream streamReader = File.OpenRead(filename))
                {
                    StreamUtils.Copy(streamReader, zipStream, buffer);
                }
                zipStream.CloseEntry();
            }
            string[] folders = Directory.GetDirectories(path);
            foreach (string folder in folders)
            {
                CompressFolder(folder, zipStream, folderOffset);
            }
        }

        public static void DeleteFilesAndFoldersRecursively(string target_dir)
        {
            foreach (string file in Directory.EnumerateFiles(target_dir))
            {
                File.Delete(file);
            }

            foreach (string subDir in Directory.GetDirectories(target_dir))
            {
                DeleteFilesAndFoldersRecursively(subDir);
            }

            Thread.Sleep(1); // This makes the difference between whether it works or not. Sleep(0) is not enough.
            Directory.Delete(target_dir);
        }

        public static string GetRelativePath(string filespec, string folder)
        {
            Uri pathUri = new Uri(filespec);
            // Folders must end in a slash
            if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                folder += Path.DirectorySeparatorChar;
            }
            Uri folderUri = new Uri(folder);
            return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString().Replace('/', Path.DirectorySeparatorChar));
        }
    }
}
