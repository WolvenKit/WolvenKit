namespace WolvenKit.Common
{
    public interface IGameArchive
    {
        #region Properties

        public string ArchiveAbsolutePath { get; set; }
        public string Name { get; }

        EArchiveType TypeName { get; }

        #endregion Properties
    }
}
