using System;
using System.IO;

namespace CP77Tools
{
    public static class Constants
    {
        public static string ResourcesPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
        public static string ArchiveHashesPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/archivehashes.csv");
        public static string ArchiveHashesZipPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/archivehashes.zip");
    }
}
