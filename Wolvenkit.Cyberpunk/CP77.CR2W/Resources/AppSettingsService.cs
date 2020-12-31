using System;
using System.IO;
using CP77.Common.Services;

namespace CP77.CR2W.Resources
{
    public class AppSettingsService : IAppSettingsService
    {
        public string ResourcesPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

        public string ETagPath => Path.Combine(ResourcesPath, "archivehashes-etag.txt");
        public string ArchiveHashesPath => Path.Combine(ResourcesPath, "archivehashes.txt");
        public string LooseHashesPath => Path.Combine(ResourcesPath, "loosehashes.txt");
        public string ArchiveHashesZipPath => Path.Combine(ResourcesPath, "archivehashes.zip");
    }
}
