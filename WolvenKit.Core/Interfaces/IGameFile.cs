using System.IO;
using System.Threading.Tasks;

namespace WolvenKit.Core.Interfaces;

/// <summary>
/// Any game file
/// </summary>
public interface IGameFile
{
    #region Properties

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
    public string GuessedExtension { get; }
    string FileName { get; }


    #endregion Properties

    public void Extract(Stream output);

    public Task ExtractAsync(Stream output);
    T GetArchive<T>() where T : IGameArchive;
    IGameArchive GetArchive();
}
