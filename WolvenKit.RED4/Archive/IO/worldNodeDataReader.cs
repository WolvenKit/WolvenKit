using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class worldNodeDataReader : Red4Reader, IBufferReader
{
    public worldNodeDataReader(MemoryStream ms) : base(ms)
    {

    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        var data = new worldNodeDataBuffer();

        while (_reader.BaseStream.Position < _reader.BaseStream.Length)
        {
            var t = new worldCompiledNodeInstanceSetupInfo();

            t.Transform.Position.X = _reader.ReadSingle();
            t.Transform.Position.Y = _reader.ReadSingle();
            t.Transform.Position.Z = _reader.ReadSingle();
            t.Transform.Position.W = _reader.ReadSingle();

            t.Transform.Orientation.I = _reader.ReadSingle();
            t.Transform.Orientation.J = _reader.ReadSingle();
            t.Transform.Orientation.K = _reader.ReadSingle();
            t.Transform.Orientation.R = _reader.ReadSingle();

            t.Scale.X = _reader.ReadSingle();
            t.Scale.Y = _reader.ReadSingle();
            t.Scale.Z = _reader.ReadSingle();

            t.SecondaryRefPointPosition.X = _reader.ReadSingle();
            t.SecondaryRefPointPosition.Y = _reader.ReadSingle();
            t.SecondaryRefPointPosition.Z = _reader.ReadSingle();

            t.StreamingRefPoint.X = _reader.ReadSingle();
            t.StreamingRefPoint.Y = _reader.ReadSingle();
            t.StreamingRefPoint.Z = _reader.ReadSingle();

            t.Uk08.X = _reader.ReadSingle();
            t.Uk08.Y = _reader.ReadSingle();
            t.Uk08.Z = _reader.ReadSingle();

            t.Id = _reader.ReadUInt64();

            t.GlobalNodeId.Hash = _reader.ReadUInt64();
            t.Uk09 = _reader.ReadUInt64();
            t.CookedPrefabData = new CResourceReference<worldCookedPrefabData>(_reader.ReadUInt64());

            t.SecondaryRefPointDistance = _reader.ReadSingle();
            t.StreamingDistance = _reader.ReadSingle();

            t.NodeIndex = _reader.ReadUInt16();

            t.Uk10 = _reader.ReadUInt16();
            t.Uk11 = _reader.ReadUInt16();
            t.Uk12 = _reader.ReadUInt16();

            // TODO: [Path-2.0] Check if its right
            t.Uk13 = _reader.ReadUInt64();
            t.Uk14 = _reader.ReadUInt64();

            if (!data.Lookup.ContainsKey(t.NodeIndex))
            {
                data.Lookup[t.NodeIndex] = new();
            }
            data.Lookup[t.NodeIndex].Add(t);
            data.Add(t);
        }

        if (buffer.Parent is worldStreamingSector wss)
        {
            wss.VariantNodes = new CArray<CArray<RedBaseClass>>();
            for (int i = 0; i < wss.VariantIndices.Count; i++)
            {
                var ra = new CArray<RedBaseClass>();
                for (int j = wss.VariantIndices[i]; j < data.Count && (((i + 1) < wss.VariantIndices.Count && j < wss.VariantIndices[i + 1]) || ((i + 1) >= wss.VariantIndices.Count && j < data.Count)); j++)
                {
                    ra.Add(data[j]);
                }
                if (i == wss.PersisentNodeIndex)
                {
                    wss.PersistentNodes = ra;
                }
                else
                {
                    wss.VariantNodes.Add(ra);
                }
            }
        }

        buffer.Data = data;

        return EFileReadErrorCodes.NoError;
    }
}