using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.Buffer;

namespace WolvenKit.RED4.Archive.IO;

public class CR2WWrapperWriter : IDisposable
{
    public ILoggerService LoggerService { get; set; }

    private Stream _ms;
    private bool _disposed;

    public CR2WWrapperWriter(Stream ms)
    {
        _ms = ms;
    }

    public void Write(CR2WWrapper wrapper)
    {
        using var cr2wWriter = new CR2WWriter(_ms) { IsRoot = false, LoggerService = LoggerService };

        cr2wWriter.WriteFile(wrapper.File);
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