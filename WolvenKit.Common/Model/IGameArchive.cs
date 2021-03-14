namespace WolvenKit.Common
{
    public interface IGameArchive
    {
        #region Properties

        string ArchiveAbsolutePath { get; set; }
        EArchiveType TypeName { get; }

        #endregion Properties
    }
}
