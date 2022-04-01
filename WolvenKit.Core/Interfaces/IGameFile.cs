using System.IO;

namespace WolvenKit.Core.Interfaces;

/// <summary>
/// Any game file
/// </summary>
public interface IGameFile
{
    #region Properties

    public IGameArchive Archive { get; set; }

    ulong Key { get; }

    string Name { get; }

    /// <summary>
    /// Uncompressed asset size in bytes
    /// </summary>
    uint Size { get; set; }

    /// <summary>
    /// Compressed asset asize in bytes
    /// </summary>
    uint ZSize { get; set; }

    public string Extension { get; }


    #endregion Properties

    public void Extract(Stream output);
}
