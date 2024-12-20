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

    public static bool SafeDelete(string filePath, ILoggerService? logger = null)
    {
        if (!File.Exists(filePath))
        {
            return true;
        }

        try
        {
            File.Delete(filePath);
        }
        catch (Exception)
        {
            logger?.Error($"Error while deleting \"{filePath}\"");
            return false;
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

    public static void MoveRecursively(string sourceDir, string destinationDir, bool overwrite, ILoggerService? logger = null)
    {
        if (Path.GetDirectoryName(destinationDir) == sourceDir)
        {
            return;
        }
        try
        {
            if (!Directory.EnumerateFileSystemEntries(sourceDir).Any())
            {
                if (Directory.Exists(destinationDir))
                {
                    Directory.Delete(sourceDir);
                    return;
                }

                Directory.Move(sourceDir, destinationDir);
                return;
            } 
            
            // Ensure the destination directory exists
            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }

            // Move all files
            var files = Directory.GetFiles(sourceDir, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var relativePath = Path.GetRelativePath(sourceDir, file);
                var destFile = Path.Combine(destinationDir, relativePath);
                var destDir = Path.GetDirectoryName(destFile);

                if (destDir is not null && !Directory.Exists(destDir))
                {
                    Directory.CreateDirectory(destDir);
                }

                if (File.Exists(destFile) && !overwrite)
                {
                    logger?.Info($"Skipping existing file {destFile}");
                    continue;
                }

                File.Move(file, destFile, true); // true allows overwriting of files
            }

            // Move all directories by recursively calling this method
            var directories = Directory.GetDirectories(sourceDir, "*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                var relativePath = Path.GetRelativePath(sourceDir, directory);
                var destDir = Path.Combine(destinationDir, relativePath);
                MoveRecursively(directory, destDir, overwrite, logger);
            }

            // Optionally, remove the source directory if it's now empty
            Directory.Delete(sourceDir, true); // true allows recursive deletion
        }
        catch (IOException e)
        {
            logger?.Error($"Error when trying to move {sourceDir}");
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