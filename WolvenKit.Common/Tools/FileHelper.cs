using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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

    public static void MoveRecursively(string sourceDirAbsPath, string destDirAbsPath, bool overwrite, string projectRootFolder,
        ILoggerService? logger = null)
    {
        // Abort if something is dragged on its own parent (this happens to mana a lot because she can't click) 
        if (sourceDirAbsPath.Equals(Path.GetDirectoryName(destDirAbsPath), StringComparison.OrdinalIgnoreCase))
        {
            return;
        }
        
        var tempId = Guid.NewGuid();
        var tempFolderRoot = $"{projectRootFolder}{Path.DirectorySeparatorChar}{tempId}";
        var destDirTemp = destDirAbsPath.ToLower().Replace(projectRootFolder.ToLower(), tempFolderRoot);
        Directory.CreateDirectory(string.Join(Path.DirectorySeparatorChar, destDirAbsPath.Split(Path.DirectorySeparatorChar)[..^1]));
        Directory.CreateDirectory(string.Join(Path.DirectorySeparatorChar,destDirTemp.Split(Path.DirectorySeparatorChar)[..^1]));
        Directory.Move(sourceDirAbsPath, destDirTemp);
        
        foreach (var file in Directory.EnumerateFiles(destDirTemp, "*", SearchOption.AllDirectories))
        {
            var newFileName = file.Replace(destDirTemp, destDirAbsPath);
            Directory.CreateDirectory(string.Join(Path.DirectorySeparatorChar, newFileName.Split(Path.DirectorySeparatorChar)[..^1]));
            
            if(!(File.Exists(newFileName) && !overwrite))
            {
                File.Move(file, newFileName, overwrite);   
            }
        }
        
        Directory.Delete(tempFolderRoot, true);
    }

    public static FileInfo? GetMostRecentlyChangedFile(string directoryPath, string searchPattern)
    {
        if (!Directory.Exists(directoryPath))
        {
            return null;
        }

        return new DirectoryInfo(directoryPath).GetFiles(searchPattern).MaxBy(f => f.LastWriteTime);
    }
    
    public static string SanitizePath(string path)
    {
        char[] additionalInvalidChars = { '?', '*', '"', '<', '>', '|', '\\', '/' };
        var invalidCharacters = Path.GetInvalidPathChars().Concat(additionalInvalidChars).Distinct().ToArray();
        var inputPath = path;
        var inputPathArray = new List<string>();
        foreach (var part in inputPath.Split(Path.DirectorySeparatorChar))
        {
            var outputPart = part.Trim();
            if (string.IsNullOrEmpty(outputPart))
            {
                continue;
            }
            outputPart = new string(outputPart.Select(c => invalidCharacters.Contains(c) ? '_' : c).ToArray());

            if (new Regex(@"^\.{3,}$").IsMatch(outputPart))
            {
                throw new Exception($"Pattern \"{outputPart}{Path.DirectorySeparatorChar}\" is not a valid relative path traversal method, consider using {'"' + @" \..\ " + '"'}.");
            }
            inputPathArray.Add(outputPart);
        }

        if (inputPathArray.Count == 0)
        {
            throw new Exception($"Path \"{path}\" is empty after sanitation");
        }
        inputPath = string.Join(Path.DirectorySeparatorChar, inputPathArray);
        return inputPath;
    }


    public static string? GetFirstExistingParentDirectory(string path)
    {
        string? currentPath = null;
        try
        {
            // Normalize the path (handle relative paths, remove trailing slashes, etc.)
            currentPath = Path.GetFullPath(path);

            // If the path itself exists and is a directory, return it
            if (Directory.Exists(currentPath))
            {
                return currentPath;
            }

            // Walk up the directory tree
            while (!string.IsNullOrEmpty(currentPath))
            {
                if (Directory.Exists(currentPath))
                {
                    return currentPath;
                }

                // Move up one level
                var parent = Directory.GetParent(currentPath)?.FullName;
                if (parent == null || parent == currentPath)
                {
                    break; // Reached root
                }

                currentPath = parent;
            }
        }
        catch
        {
            return null;
        }

        return Directory.Exists(currentPath) ? currentPath : null;
    }
}