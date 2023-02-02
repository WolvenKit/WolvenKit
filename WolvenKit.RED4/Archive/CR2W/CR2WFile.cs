using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.CR2W;

public class CR2WMetaData
{
    public string? FileName { get; set; }
    public uint Version { get; set; } = 195;
    public uint BuildVersion { get; set; } = 0;
    public EHashVersion HashVersion { get; set; }
    public uint ObjectsEnd { get; set; }
}

public class CR2WFile : Red4File, IDisposable, IEquatable<CR2WFile>
{
    public const uint MAGIC = 0x57325243; // "W2RC"
    public const uint DEADBEEF = 0xDEADBEEF;


    public CR2WFileInfo Info { get; internal set; } = new();
    public CR2WMetaData MetaData { get; set; } = new();


    public IList<ICR2WProperty> Properties { get; }

    public RedBaseClass RootChunk { get; set; }

    public IList<ICR2WEmbeddedFile> EmbeddedFiles { get; }

    public CR2WFile()
    {
        Properties = new List<ICR2WProperty>();     //block 4
        EmbeddedFiles = new List<ICR2WEmbeddedFile>();       //block 7
    }

    #region Events
    /*
#pragma warning disable CS0067
    public event ObjectChangedEventHandler ObjectChanged;
#pragma warning restore CS0067

    public void AttachEventHandler()
    {
        RootChunk.ObjectChanged += OnObjectChanged;

        foreach (var embeddedFile in EmbeddedFiles)
        {
            embeddedFile.Content.ObjectChanged += OnObjectChanged;
        }
    }

    private void OnObjectChanged(object sender, ObjectChangedEventArgs e)
    {

    }
    */
    #endregion

    #region Methods

    public List<RedBuffer> GetBuffers()
    {
        var result = new List<RedBuffer>();

        var buffers = FindType(typeof(IRedBufferWrapper));
        foreach (var entry in buffers)
        {
            result.Add(((IRedBufferWrapper)entry.Value).Buffer);
        }

        return result;
    }

    public List<CName> GetImports()
    {
        var result = new List<CName>();

        foreach (var embeddedFile in EmbeddedFiles)
        {
            result.Add(embeddedFile.FileName);
        }

        var resources = FindType(typeof(IRedRef));
        foreach (var entry in resources)
        {
            result.Add(((IRedRef)entry.Value).DepotPath);
        }

        return result;
    }

    public List<RedBaseClass.FindResult> FindType(Type targetTypes)
    {
        var result = new List<RedBaseClass.FindResult>();

        result.AddRange(RootChunk.FindType(targetTypes));

        for (var i = 0; i < EmbeddedFiles.Count; i++)
        {
            result.AddRange(EmbeddedFiles[i].Content.FindType(targetTypes, $"emb{i}"));
        }

        return result;
    }

    public (bool, IRedType?) GetFromXPath(string xPath)
    {
        var parts = xPath.Split('.');

        if (parts[0] == "root")
        {
            return RootChunk.GetFromXPath(parts[1..]);
        }

        if (parts[0].StartsWith("emb"))
        {
            if (int.TryParse(parts[0][3..], out var index))
            {
                return EmbeddedFiles[index].Content.GetFromXPath(parts[1..]);
            }
        }

        return (false, null);
    }

    #endregion Methods

    #region IDisposable

    private bool _disposed;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
            }

            _disposed = true;
        }
    }

    ~CR2WFile()
    {
        Dispose(false);
    }

    #endregion

    public bool Equals(CR2WFile? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (!Equals(RootChunk, other.RootChunk))
        {
            return false;
        }

        if (!Equals(EmbeddedFiles.Count, other.EmbeddedFiles.Count))
        {
            return false;
        }

        for (var i = 0; i < EmbeddedFiles.Count; i++)
        {
            if (!Equals(EmbeddedFiles[i], other.EmbeddedFiles[i]))
            {
                return false;
            }
        }

        return true;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return Equals((CR2WFile)obj);
    }

    public override int GetHashCode() => HashCode.Combine(RootChunk, EmbeddedFiles);
}