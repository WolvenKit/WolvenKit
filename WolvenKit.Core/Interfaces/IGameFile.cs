using System.IO;
using System.Threading.Tasks;
using WolvenKit.Common;

namespace WolvenKit.Core.Interfaces;

/// <summary>
/// Any game file
/// </summary>
public interface IGameFile
{
    #region Properties

    /// <summary>
    /// Game file's unique hash
    /// </summary>
    ulong Key { get; }

    /// <summary>
    /// File name with extension (but without path)
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Uncompressed asset size in bytes
    /// </summary>
    uint Size { get; set; }

    /// <summary>
    /// Compressed asset size in bytes
    /// </summary>
    uint ZSize { get; set; }

    /// <summary>
    /// Extension of the file without the dot (e.g. "mesh").
    /// </summary>
    public string Extension { get; }

    public string? GuessedExtension { get; }

    /// <summary>
    /// File's relative path with file name and extension.
    /// </summary>
    string FileName { get; }

    /// <summary>
    /// The game file's <see cref="ArchiveManagerScope"/>
    /// </summary>
    ArchiveManagerScope Scope { get; set; }

    #endregion Properties

    public void Extract(Stream output);

    public Task ExtractAsync(Stream output);

    T GetArchive<T>() where T : IGameArchive;
    
    IGameArchive GetArchive();
}
