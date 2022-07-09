using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using WolvenKit.Common;

namespace WolvenKit.Interfaces.Extensions
{
    public static class StringExtensions
    {
        public static string FirstCharToLower(this string input)
        {
            return input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => input.First().ToString().ToLower() + input[1..],
            };
        }

        public static string FirstCharToUpper(this string input) => input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
            _ => input.First().ToString().ToUpper() + input[1..]
        };

        // https://stackoverflow.com/a/3695190
        public static void EnsureFolderExists(this string path)
        {
            var directoryName = Path.GetDirectoryName(path);
            // If path is a file name only, directory name will be an empty string
            if (!string.IsNullOrEmpty(directoryName))
            {
                // Create all directories on the path that don't already exist
                Directory.CreateDirectory(directoryName);
            }
        }

        public static string GetHashMD5(this string input)
        {
            var encodedPassword = new UTF8Encoding().GetBytes(input);
            var hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            var encoded = BitConverter.ToString(hash)
               .Replace("-", string.Empty)
               .ToLower();
            return encoded;
        }

        public static (string, bool, EProjectFolders) GetModRelativePath(this string fullpath, string activeModFileDirectory)
        {
            var relativePath = fullpath[(activeModFileDirectory.Length + 1)..];
            bool isDLC;
            var projectfolder = EProjectFolders.Cooked;

            if (relativePath.StartsWith("DLC\\"))
            {
                isDLC = true;
            }
            else if (relativePath.StartsWith("Mod\\"))
            {
                isDLC = false;
            }
            else
            {
                throw new NotImplementedException();
            }

            relativePath = relativePath[4..];

            if (relativePath.StartsWith(EProjectFolders.Cooked.ToString()))
            {
                relativePath = relativePath[(EProjectFolders.Cooked.ToString().Length + 1)..];
                projectfolder = EProjectFolders.Cooked;
            }

            if (relativePath.StartsWith(EProjectFolders.Uncooked.ToString()))
            {
                relativePath = relativePath[(EProjectFolders.Uncooked.ToString().Length + 1)..];
                projectfolder = EProjectFolders.Uncooked;
            }
            else if (relativePath.StartsWith(EArchiveType.SoundCache.ToString()))
            {
                relativePath = relativePath[(EArchiveType.SoundCache.ToString().Length + 1)..];
            }
            else if (relativePath.StartsWith(EArchiveType.Speech.ToString()))
            {
                relativePath = relativePath[(EArchiveType.Speech.ToString().Length + 1)..];
            }

            return (relativePath, isDLC, projectfolder);
        }

        public static uint HashStringKey(this string key)
        {
            var keyConverted = key.ToCharArray();
            uint hash = 0;
            foreach (var c in keyConverted)
            {
                hash *= 31;
                hash += c;
            }
            return hash;
        }

        public static string TrimStart(this string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString))
            {
                return target;
            }

            var result = target;
            while (result.StartsWith(trimString))
            {
                result = result[trimString.Length..];
            }

            return result;
        }
    }
}
