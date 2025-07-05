using System.Text;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Save;

namespace WolvenKit.RED4.Archive.IO;

public class SavedModifierGroupStatTypesBufferWriter : IDisposable
{
    public ILoggerService LoggerService { get; set; }

    private Stream _ms;
    private bool _disposed;

    public SavedModifierGroupStatTypesBufferWriter(Stream ms)
    {
        _ms = ms;
    }

    public void WriteBuffer(SavedModifierGroupStatTypesBuffer buffer)
    {
        using var bw = new BinaryWriter(_ms, Encoding.UTF8, true);

        foreach (var entry in buffer.Entries)
        {
            bw.Write(entry.ModifierGroupHash);
            
            bw.Write(entry.StatTypes.Count);
            foreach (var gamedataStatType in entry.StatTypes)
            {
                bw.Write(SaveHashHelper.GetStatHash(gamedataStatType));
            }
        }
    }

    #region IDisposable

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _ms.Close();
            }
            _disposed = true;
        }
    }

    public void Dispose() => Dispose(true);

    public virtual void Close() => Dispose(true);

    #endregion IDisposable
}