using System;
using System.IO;
using System.Linq;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Helpers;

public class FileHelper
{
    public static bool SafeWrite(Stream stream, string outPath, ILoggerService? logger = null)
    {
        var tmpPath = Path.ChangeExtension(outPath, "tmp");

        if (!SafeDelete(tmpPath, logger) || !SafeDelete(outPath, logger))
        {
            return false;
        }

        using (var fs = File.Create(tmpPath))
        {
            stream.Position = 0;
            stream.CopyTo(fs);
        }

        if (!SafeMove(tmpPath, outPath, logger))
        {
            return false;
        }

        if (!SafeDelete(tmpPath, logger))
        {
            return false;
        }

        return true;
    }

    public static bool SafeDelete(string path, ILoggerService? logger = null)
    {
        if (File.Exists(path))
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception)
            {
                logger?.Error($"Error while deleting file \"{path}\"");
                return false;
            }
        }
        else if (Directory.Exists(path))
        {
            try
            {
                Directory.Delete(path, true); // true allows recursive deletion
            }
            catch (Exception)
            {
                logger?.Error($"Error while deleting directory \"{path}\"");
                return false;
            }
        }

        return true;
    }

    public static bool SafeMove(string inFilePath, string outFilePath, ILoggerService? logger = null)
    {
        try
        {
            File.Move(inFilePath, outFilePath);
        }
        catch (Exception)
        {
            logger?.Error($"Error while moving \"{inFilePath}\" to \"{outFilePath}\"");
            return false;
        }

        return true;
    }

    public static void MoveRecursively(string sourceDirAbsPath, string destDirAbsPath, bool overwrite,
        ILoggerService? logger = null)
    {
        // Abort if something is dragged on its own parent (this happens to mana a lot because she can't click) 
        if (sourceDirAbsPath.Equals(Path.GetDirectoryName(destDirAbsPath), StringComparison.OrdinalIgnoreCase))
        {
            return;
        }

        var destDirTemp = $"{destDirAbsPath}_temp";
        try
        {
            // source dir is an empty directory
            if (Directory.Exists(sourceDirAbsPath) && !Directory.EnumerateFileSystemEntries(sourceDirAbsPath).Any())
            {
                if (!Directory.Exists(destDirAbsPath))
                {
                    Directory.CreateDirectory(destDirAbsPath);
                }

                Directory.Delete(sourceDirAbsPath);
                return;
            } 
            
            // Ensure the destination directory exists
            if (!Directory.Exists(destDirTemp))
            {
                Directory.CreateDirectory(destDirTemp);
            }

            // Move all files
            var files = Directory.GetFiles(sourceDirAbsPath, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var relativePath = Path.GetRelativePath(sourceDirAbsPath, file);
                var destFile = Path.Combine(destDirAbsPath, relativePath);
                var destDir = Path.GetDirectoryName(destFile);
                
                if (destDir is not null && !Directory.Exists(destDir))
                {
                    Directory.CreateDirectory(destDir);
                }

                // renaming file.ext to File.ext will delete it, so rename it to .tmp first
                File.Move(file, $"{destFile}.tmp", true);
                File.Move($"{destFile}.tmp", destFile, true);
            }

            // Move all directories by recursively calling this method
            var directories = Directory.GetDirectories(sourceDirAbsPath, "*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                var relativePath = Path.GetRelativePath(sourceDirAbsPath, directory);
                var destSubDirAbsPath = Path.Combine(destDirAbsPath, relativePath);
                MoveRecursively(directory, destSubDirAbsPath, overwrite, logger);
            }

            // recursive delete the source directory - all our files are in destDirTemp
            Directory.Delete(sourceDirAbsPath, true);

            Directory.Move(destDirTemp, destDirAbsPath);

        }
        catch (IOException e)
        {
            logger?.Error($"Error when trying to move {sourceDirAbsPath}");
            logger?.Error(e);
        }
    }

    public static FileInfo? GetMostRecentlyChangedFile(string directoryPath, string searchPattern)
    {
        if (!Directory.Exists(directoryPath))
        {
            return null;
        }

        return new DirectoryInfo(directoryPath).GetFiles(searchPattern).MaxBy(f => f.LastWriteTime);
    }
    
}