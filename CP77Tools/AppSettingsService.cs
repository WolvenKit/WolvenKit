using System;
using System.IO;
using CP77.Common.Services;

namespace CP77Tools
{
    public class AppSettingsService : IAppSettingsService
    {
        public string ResourcesPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
        public string ArchiveHashesPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/archivehashes.txt");
        public string LooseHashesPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/archivehashes.csv");
        public string ArchiveHashesZipPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/archivehashes.zip");
    }
}
