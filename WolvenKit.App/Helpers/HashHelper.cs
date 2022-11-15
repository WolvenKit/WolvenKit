using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace WolvenKit.App.Helpers;
internal static class HashHelper
{
    /// <summary>
    /// Calculates the SHA256 hash of a physical file
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static string CalculateFileHash(string filePath)
    {
        using var mySHA256 = SHA256.Create();
        var fInfo = new FileInfo(filePath);
        using var fileStream = fInfo.Open(FileMode.Open);
        try
        {
            fileStream.Position = 0;
            return string.Concat(mySHA256.ComputeHash(fileStream).Select(b => b.ToString("X2")));
        }
        catch (IOException)
        {
            throw;
        }
        catch (UnauthorizedAccessException)
        {
            throw;
        }
    }
}
