using System.Text;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Archive.IO;

public class PxCollectionWriter : IDisposable
{
    private readonly BinaryWriter _writer;

    public PxCollectionWriter(Stream stream) => _writer = new BinaryWriter(stream, Encoding.UTF8, true);

    public void WriteBuffer(physicsMaterialLibraryResource resource)
    {
        var dict = new SortedDictionary<string, physicsMaterialResource>(StringComparer.Ordinal);

        dict.Add("", resource.DefaultMaterial!);
        for (var i = 0; i < resource.MaterialNames.Count; i++)
        {
            var name = resource.MaterialNames[i].GetResolvedText()!;
            var material = resource.MaterialValues[i].Chunk!;

            dict.Add(name, material);
        }
        var matList = dict.Values.ToList();

        _writer.Write(1145193811); // FOURCC("SEBD")
        _writer.Write(50594560); // Version 3.4.3
        _writer.Write(0); // BinaryVersion
        _writer.Write(0); // BuildNumber
        _writer.Write(875978583); // PlatformTag => FOURCC("W_64")
        _writer.Write(1); // MarkedPadding
        Pad();

        _writer.Write(matList.Count); // nbObjectsInCollection
        Pad();

        _writer.Write(matList.Count); // nbManifestEntries
        for (var i = 0; i < matList.Count; i++) // manifestEntries
        {
            _writer.Write(80 * i);
            _writer.Write((ushort)9); // PxConcreteType.eMATERIAL
            _writer.Write([0xCD, 0xCD]); // Padding
        }
        _writer.Write(80 * matList.Count); // objectDataEndOffset
        Pad();

        _writer.Write(0); // nbImportReferences
        Pad();

        _writer.Write(matList.Count); // nbExportReferences
        for (var i = 0; i < matList.Count; i++)
        {
            _writer.Write(matList[i].Id);
            _writer.Write(i);
            _writer.Write([0xCD, 0xCD, 0xCD, 0xCD]); // Padding
        }
        Pad();

        _writer.Write(matList.Count); // nbInternalPtrReferences
        for (var i = 0; i < matList.Count; i++)
        {
            _writer.Write((ulong)(0x80000001 + i));
            _writer.Write(i);
            _writer.Write([0xCD, 0xCD, 0xCD, 0xCD]); // Padding
        }

        _writer.Write(matList.Count); // internalIdxReferences
        for (var i = 0; i < matList.Count; i++)
        {
            _writer.Write((ushort)i);
            _writer.Write([0xCD, 0xCD]); // Padding
            _writer.Write(i);
        }
        Pad();

        for (var i = 0; i < matList.Count; i++)
        {
            var material = matList[i];

            _writer.Write([0x78, 0x56, 0x34, 0x12]);
            _writer.Write(0); // unknown
            _writer.Write((ushort)9); // PxConcreteType.eMATERIAL
            _writer.Write((ushort)3); // unknown, version?
            _writer.Write([0xCD, 0xCD, 0xCD, 0xCD]); // Padding

            _writer.Write([0x78, 0x56, 0x34, 0x12]);
            _writer.Write(0); // unknown
            _writer.Write([0x78, 0x56, 0x34, 0x12]);
            _writer.Write(0); // unknown

            _writer.Write(1); // unknown, refCount?
            _writer.Write([0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD]); // Padding

            _writer.Write(material.DynamicFriction);
            _writer.Write(material.StaticFriction);
            _writer.Write(material.Restitution);
            switch ((physicsMaterialFriction)material.FrictionMode)
            {
                case physicsMaterialFriction.Enabled:
                    _writer.Write((ushort)0);
                    break;

                case physicsMaterialFriction.DisabledStrong:
                    _writer.Write((ushort)2);
                    break;

                case physicsMaterialFriction.Disabled:
                    _writer.Write((ushort)1);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            _writer.Write((byte)0); // PxCombineMode.eAVERAGE
            _writer.Write([0xCD]); // Padding

            _writer.Write((ulong)(0x80000001 + i));
            _writer.Write((ushort)i); // unknown
            _writer.Write([0xCD, 0xCD, 0xCD, 0xCD, 0xCD, 0xCD]); // Padding
        }

        _writer.Flush();
    }

    private void Pad()
    {
        var size = 16 - (_writer.BaseStream.Position % 16);
        for (var i = 0; i < size; i++)
        {
            _writer.Write((byte)0x42);
        }
    }

    #region IDisposable

    private bool _disposed;

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _writer.Close();
            }
            _disposed = true;
        }
    }

    public void Dispose() => Dispose(true);

    public virtual void Close() => Dispose(true);

    #endregion IDisposable
}
