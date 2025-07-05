using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.Win32;
using WolvenKit.Core.Extensions;

namespace WolvenKit.App.Helpers;

public static class Commonfunctions
{


    /// <summary>
    /// Check if a registry value exists
    /// </summary>
    /// <param name="hive"></param>
    /// <param name="registryRoot"></param>
    /// <param name="valueName"></param>
    /// <returns></returns>
    public static bool RegistryValueExists(RegistryHive hive, string registryRoot, string valueName)
    {
        var root = hive switch
        {
            RegistryHive.LocalMachine => Registry.LocalMachine.OpenSubKey(registryRoot, false),
            RegistryHive.CurrentUser => Registry.CurrentUser.OpenSubKey(registryRoot, false),
            RegistryHive.ClassesRoot => throw new InvalidOperationException("parameter registryRoot must be either \"HKLM\" or \"HKCU\""),
            RegistryHive.Users => throw new InvalidOperationException("parameter registryRoot must be either \"HKLM\" or \"HKCU\""),
            RegistryHive.PerformanceData => throw new InvalidOperationException("parameter registryRoot must be either \"HKLM\" or \"HKCU\""),
            RegistryHive.CurrentConfig => throw new InvalidOperationException("parameter registryRoot must be either \"HKLM\" or \"HKCU\""),
            _ => throw new InvalidOperationException("parameter registryRoot must be either \"HKLM\" or \"HKCU\""),
        };
        return root?.GetValue(valueName) != null;
    }


    /// <summary>
    /// Compresses a file into a zipstream.
    /// </summary>
    /// <param name="filename">Path to the file.</param>
    /// <param name="zipStream">The zipstream to output to.</param>
    /// <param name="nameOverride">Rename the file to a costum name.</param>
    public static void CompressFile(string filename, ZipOutputStream zipStream, string nameOverride = "")
    {
        var fi = new FileInfo(filename);

        var entryName = Path.GetFileName(filename);
        if (nameOverride != "")
        {
            entryName = nameOverride;
        }

        entryName = ZipEntry.CleanName(entryName);
        var newEntry = new ZipEntry(entryName) { DateTime = fi.LastWriteTime, Size = fi.Length };
        zipStream.PutNextEntry(newEntry);
        var buffer = new byte[4096];
        using (var streamReader = File.OpenRead(filename))
        {
            StreamUtils.Copy(streamReader, zipStream, buffer);
        }
        zipStream.CloseEntry();
    }

    /// <summary>
    /// Compresses a folder of files into a zipstream.
    /// </summary>
    /// <param name="path">The path of the folder.</param>
    /// <param name="zipStream">The output zipstream.</param>
    /// <param name="folderOffset">The folderoffset.</param>
    public static void CompressFolder(string path, ZipOutputStream zipStream, int folderOffset)
    {
        var files = Directory.GetFiles(path);

        foreach (var filename in files)
        {
            var fi = new FileInfo(filename);
            var entryName = filename[folderOffset..];
            entryName = ZipEntry.CleanName(entryName);
            var newEntry = new ZipEntry(entryName) { DateTime = fi.LastWriteTime, Size = fi.Length };
            zipStream.PutNextEntry(newEntry);
            var buffer = new byte[4096];
            using (var streamReader = File.OpenRead(filename))
            {
                StreamUtils.Copy(streamReader, zipStream, buffer);
            }
            zipStream.CloseEntry();
        }
        var folders = Directory.GetDirectories(path);
        foreach (var folder in folders)
        {
            CompressFolder(folder, zipStream, folderOffset);
        }
    }

    /// <summary>
    /// Compresses a byte array to a zipstream.
    /// </summary>
    /// <param name="file">The byte array to compress.</param>
    /// <param name="filename">The entry name.</param>
    /// <param name="zipStream">The zipstream which we want to output this file to.</param>
    public static void CompressStream(byte[] file, string filename, ZipOutputStream zipStream)
    {
        filename = ZipEntry.CleanName(filename);
        var newEntry = new ZipEntry(filename) { DateTime = DateTime.Now, Size = file.Length };
        zipStream.PutNextEntry(newEntry);
        var buffer = new byte[4096];
        StreamUtils.Copy(new MemoryStream(file), zipStream, buffer);
        zipStream.CloseEntry();
    }

    /// <summary>
    /// Deletes a non empty directory
    /// </summary>
    /// <param name="targetDir">The directory to delete.</param>
    public static void DeleteDirectory(string targetDir)
    {
        var files = Directory.GetFiles(targetDir);
        var dirs = Directory.GetDirectories(targetDir);

        foreach (var file in files)
        {
            File.SetAttributes(file, FileAttributes.Normal);
            File.Delete(file);
        }

        foreach (var dir in dirs)
        {
            DeleteDirectory(dir);
        }

        Directory.Delete(targetDir, false);
    }

    /// <summary>
    /// Deletes files and folders in given folder.
    /// </summary>
    /// <param name="target_dir">Targed directory.</param>
    public static void DeleteFilesAndFoldersRecursively(string target_dir)
    {
        foreach (var file in Directory.EnumerateFiles(target_dir))
        {
            File.Delete(file);
        }

        foreach (var subDir in Directory.GetDirectories(target_dir))
        {
            DeleteFilesAndFoldersRecursively(subDir);
        }

        Thread.Sleep(1); // This makes the difference between whether it works or not. Sleep(0) is not enough.
        Directory.Delete(target_dir);
    }

    /// <summary>
    /// Copies the contents of a directory.
    /// </summary>
    /// <param name="sourceDirName">The source directory.</param>
    /// <param name="destDirName">The destination.</param>
    /// <param name="copySubDirs">Whether to copy subdirectories.</param>
    /// <returns>A log of copied files.</returns>
    public static List<XElement> DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
    {
        var ret = new List<XElement>();
        var dir = new DirectoryInfo(sourceDirName);
        var dirs = dir.GetDirectories();

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
        var files = dir.GetFiles();

        foreach (var file in files)
        {
            // Create the path to the new copy of the file.
            var temppath = Path.Combine(destDirName, file.Name);

            // Copy the file.
            ret.Add(new XElement("file", temppath));
            file.CopyTo(temppath, true);
        }

        // If copySubDirs is true, copy the subdirectories.
        if (copySubDirs)
        {
            foreach (var subdir in dirs)
            {
                // Create the subdirectory.
                var temppath = Path.Combine(destDirName, subdir.Name);

                // Copy the subdirectories.
                if (Directory.GetFiles(subdir.FullName, "*", SearchOption.AllDirectories).Any())
                {
                    ret.Add(new XElement("Directory", new XAttribute("Path", temppath), DirectoryCopy(subdir.FullName, temppath, copySubDirs)));
                }
            }
        }
        return ret;
    }

    /// <summary>
    /// Moves a directory's contents to anothet directory
    /// </summary>
    /// <param name="SourcePath">The old dir (will be deleted)</param>
    /// <param name="DestinationPath">The new dir (will be created)</param>
    public static void DirectoryMove(string SourcePath, string DestinationPath)
    {
        var oi = new DirectoryInfo(SourcePath);
        var newdir = Path.Combine(oi.Parent.NotNull().FullName, oi.Name + "_old");
        oi.MoveTo(newdir);
        //Now Create all of the directories
        foreach (var dirPath in Directory.GetDirectories(newdir, "*",
            SearchOption.AllDirectories))
        {
            Directory.CreateDirectory(dirPath.Replace(newdir, DestinationPath));
        }

        //Copy all the files & Replaces any files with the same name
        foreach (var newPath in Directory.GetFiles(newdir, "*.*",
            SearchOption.AllDirectories))
        {
            File.Move(newPath, newPath.Replace(newdir, DestinationPath));
        }

        //Delete the old directory
        DeleteDirectory(newdir);
    }

    /// <summary>
    /// Gets relative path from absolute path.
    /// </summary>
    /// <param name="filespec">A files path.</param>
    /// <param name="folder">The folder's path.</param>
    /// <returns></returns>
    public static string GetRelativePath(string filespec, string folder)
    {
        var pathUri = new Uri(filespec);
        // Folders must end in a slash
        if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
        {
            folder += Path.DirectorySeparatorChar;
        }
        var folderUri = new Uri(folder);
        return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString().Replace('/', Path.DirectorySeparatorChar));
    }

    /// <summary>
    /// Opens command prompt at given location
    /// </summary>
    /// <param name="path"></param>
    public static void OpenConsoleAtPath(string path)
    {
        using var process = Process.Start(new ProcessStartInfo("cmd.exe")
        {
            UseShellExecute = false,
            WorkingDirectory = path
        });
        process?.WaitForExit();
    }

    /// <summary>
    /// Show the given path in the windows explorer.
    /// </summary>
    /// <param name="path">The file/folder to show.</param>
    public static void ShowFileInExplorer(string path)
    {
        if (File.Exists(path))
        {
            var parent = new FileInfo(path).Directory;
            if (parent is not null && parent.Exists)
            {
                var cmd = new Process()
                {
                    StartInfo = new ProcessStartInfo()
                    {
                        FileName = "cmd",
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardInput = true
                    }
                };
                cmd.Start();
                var processId = cmd.Id;
                var args = $"start \"\" \"{parent}\"\r\n";
                cmd.StandardInput.Write(args);
                cmd.StandardInput.Write("exit\r\n");
                cmd = null;

                try
                {
                    var isCmdStillThere = Process.GetProcessById(processId);
                }
                catch (Exception errorQueryingProcess)
                {
                    Debug.Assert(errorQueryingProcess.Message == "Process with an Id of " + processId + " is not running.");
                }
            }
        }
    }

    /// <summary>
    /// Show the given folder in the windows explorer.
    /// </summary>
    /// <param name="path">The file/folder to show.</param>
    public static void ShowFolderInExplorer(string path)
    {
        if (Directory.Exists(path))
        {
            var cmd = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = "cmd",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardInput = true
                }
            };
            cmd.Start();
            var processId = cmd.Id;
            var args = $"start \"\" \"{path}\"\r\n";
            cmd.StandardInput.Write(args);
            cmd.StandardInput.Write("exit\r\n");
            cmd = null;

            try
            {
                var isCmdStillThere = Process.GetProcessById(processId);
            }
            catch (Exception errorQueryingProcess)
            {
                Debug.Assert(errorQueryingProcess.Message == "Process with an Id of " + processId + " is not running.");
            }
        }
    }

    /// <summary>
    /// Converts an XDocuments to a byte array.
    /// </summary>
    /// <param name="xdoc">The xdocument which we want to convert.</param>
    /// <returns>The byte contents of the array.</returns>
    public static byte[] XDocToByteArray(XDocument xdoc)
    {
        var ms = new MemoryStream();
        var xws = new XmlWriterSettings
        {
            OmitXmlDeclaration = true,
            Indent = true
        };

        using (var xw = XmlWriter.Create(ms, xws))
        {
            xdoc.WriteTo(xw);
        }
        return ms.ToArray();
    }

}
