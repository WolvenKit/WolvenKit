using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;

namespace WolvenKit.Common.Extensions
{
    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        public static string FirstCharToLower(this string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToLower() + input.Substring(1);
            }
        }

        public static string GetHashMD5(this string input)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(input);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string encoded = BitConverter.ToString(hash)
               .Replace("-", string.Empty)
               .ToLower();
            return encoded;
        }

        public static string TrimStart(this string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString)) return target;

            string result = target;
            while (result.StartsWith(trimString))
            {
                result = result.Substring(trimString.Length);
            }

            return result;
        }

        public static (string, bool) GetModRelativePath(this string fullpath, string activeModFileDirectory)
        {
            var relativePath = fullpath.Substring(activeModFileDirectory.Length + 1);
            bool isDLC = false;
            if (relativePath.StartsWith("DLC\\"))
                isDLC = true;
            else if (relativePath.StartsWith("Mod\\"))
                isDLC = false;
            else
            {
                throw new NotImplementedException();
            }

            relativePath = relativePath.Substring(4);
            if (relativePath.StartsWith(EBundleType.Bundle.ToString()))
                relativePath = relativePath.Substring(EBundleType.Bundle.ToString().Length + 1);
            else if (relativePath.StartsWith(EBundleType.TextureCache.ToString()))
                relativePath = relativePath.Substring(EBundleType.TextureCache.ToString().Length + 1);
            else if (relativePath.StartsWith(EBundleType.CollisionCache.ToString()))
                relativePath = relativePath.Substring(EBundleType.CollisionCache.ToString().Length + 1);
            else if (relativePath.StartsWith(EBundleType.SoundCache.ToString()))
                relativePath = relativePath.Substring(EBundleType.SoundCache.ToString().Length + 1);
            else if (relativePath.StartsWith(EBundleType.Speech.ToString()))
                relativePath = relativePath.Substring(EBundleType.Speech.ToString().Length + 1);

            return (relativePath, isDLC);
        }

    }
}
