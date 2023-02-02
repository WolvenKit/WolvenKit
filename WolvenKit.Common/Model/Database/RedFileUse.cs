namespace WolvenKit.Common.Model.Database;

public class RedFileUse
{
    public int RedFileId { get; set; }
    public RedFile? RedFile { get; set; }

    public ulong Hash { get; set; }
}
