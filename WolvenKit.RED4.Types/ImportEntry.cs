namespace WolvenKit.RED4.Types;

public class ImportEntry
{
    public ImportEntry(CName className, CName depotPath, ushort flag)
    {
        ClassName = className;
        DepotPath = depotPath;
        Flag = flag;
    }

    public CName ClassName { get; }
    public CName DepotPath { get; }
    public ushort Flag { get; set; }
}
