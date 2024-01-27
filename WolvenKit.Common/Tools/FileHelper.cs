using System;
using System.IO;
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
}