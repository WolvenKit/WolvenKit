namespace CP77.Common.Services
{
    public interface IAppSettingsService
    {
        public string ETagPath { get; }
        public string ResourcesPath { get; }
        public string ArchiveHashesPath { get; }
        public string LooseHashesPath { get; }
        public string ArchiveHashesZipPath { get; }
    }
}
