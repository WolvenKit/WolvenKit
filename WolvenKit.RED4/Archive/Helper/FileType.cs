namespace WolvenKit.RED4.Archive;

public class FileType
{
    public FileType(ERedExtension extension, string description, Type rootType)
    {
        Extension = extension;
        Description = description;
        RootType = rootType;
    }

    public ERedExtension Extension { get; }
    public string Description { get; }
    public Type RootType { get; }
}
