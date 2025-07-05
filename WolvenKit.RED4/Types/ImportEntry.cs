namespace WolvenKit.RED4.Types;

public class ImportEntry
{
    public ImportEntry(CName className, ResourcePath depotPath, ushort flag)
    {
        ClassName = className;
        DepotPath = depotPath;
        Flag = flag;
    }

    public CName ClassName { get; }
    public ResourcePath DepotPath { get; }
    public ushort Flag { get; set; }
}
