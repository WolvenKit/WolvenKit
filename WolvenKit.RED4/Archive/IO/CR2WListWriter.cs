using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class CR2WListWriter : IDisposable
{
    private Stream _ms;
    private bool _disposed;

    public CR2WListWriter(Stream ms)
    {
        _ms = ms;
    }

    public void WriteList(CR2WList list, RedBaseClass parent)
    {
        var meshMeshMaterialBuffer = parent as meshMeshMaterialBuffer;
        if (meshMeshMaterialBuffer != null)
        {
            list.Files = new();
            foreach (var material in meshMeshMaterialBuffer.Materials)
            {
                var file = new CR2WFile()
                {
                    RootChunk = material
                };
                list.Files.Add(file);
            }
        }

        var headers = new CArray<meshLocalMaterialHeader>();
        var startingPosition = _ms.Position;
        foreach (var file in list.Files)
        {
            var header = new meshLocalMaterialHeader();
            var ms = new MemoryStream();
            var cr2wWriter = new CR2WWriter(ms) {IsRoot = meshMeshMaterialBuffer != null};
            cr2wWriter.WriteFile(file);
            header.Offset = (CUInt32)(_ms.Position - startingPosition);
            _ms.Write(ms.ToArray());
            header.Size = (CUInt32)(_ms.Position - header.Offset);
            headers.Add(header);
        }

        if (meshMeshMaterialBuffer != null)
        {
            meshMeshMaterialBuffer.RawDataHeaders = headers;
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