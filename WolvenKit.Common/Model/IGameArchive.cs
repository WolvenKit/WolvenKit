namespace WolvenKit.Common.Model
{
    public interface IGameArchive
    {
        EArchiveType TypeName { get; }
        string ArchiveAbsolutePath { get; set; }
    }
}
