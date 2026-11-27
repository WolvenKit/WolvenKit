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
        if (buffer.Parent is not worldStreamingSector wss)
        {
            return EFileReadErrorCodes.Malformed;
        }

        return (int)wss.Version switch
        {
            62 => ReadBufferV62(buffer, wss),
            68 => ReadBufferV68(buffer, wss),
            _ => throw new NotSupportedException()
        };
    }

    public EFileReadErrorCodes ReadBufferV68(RedBuffer buffer, worldStreamingSector wss)
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

            t.PreboostStreamingRefPoint.X = _reader.ReadSingle();
            t.PreboostStreamingRefPoint.Y = _reader.ReadSingle();
            t.PreboostStreamingRefPoint.Z = _reader.ReadSingle();

            t.PatchedNode = _reader.ReadUInt64();

            t.GlobalNodeId = new worldGlobalNodeID
            {
                Hash = _reader.ReadUInt64()
            };

            t.ProxyMeshId = new worldGlobalNodeID
            {
                Hash = _reader.ReadUInt64()
            };

            t.ExternalInplaceResourceHash = new CResourceReference<worldCookedPrefabData>(_reader.ReadUInt64());

            var bitfields = _reader.ReadUInt64();
            t.NodeIdx = bitfields & 0x7_FFFF;
            t.NodeFlags = (Enums.ENodeFlags)((bitfields >> 19) & 0x1F_FFFF);
            t.StreamingPriority = (bitfields >> 40) & 0x00FF;
            t.TodvisMask = (bitfields >> 48) & 0xFFFF;

            t.SecondaryRefPointDistance = ReadCFloat();
            t.StreamingDistance = ReadCFloat();

            t.InstanceIndex = _reader.ReadUInt32();
            t.DataGroup = (Enums.worldStreamingDataGroup)_reader.ReadByte();

            var bytes = _reader.ReadBytes(11); // padding
            if (bytes.Any(b => b != 0))
            {
                throw new Exception("Non-zero padding bytes found");
            }

            if (!data.Lookup.ContainsKey(t.NodeIdx))
            {
                data.Lookup[t.NodeIdx] = new();
            }
            data.Lookup[t.NodeIdx].Add(t);
            data.Add(t);
        }

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

        buffer.Data = data;

        return EFileReadErrorCodes.NoError;
    }

    public EFileReadErrorCodes ReadBufferV62(RedBuffer buffer, worldStreamingSector wss)
    {
        var data = new worldNodeDataBuffer();

        while (_reader.BaseStream.Position < _reader.BaseStream.Length)
        {
            var t = new Types.Legacy.V2310.worldCompiledNodeInstanceSetupInfo();

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

            t.PreboostStreamingRefPoint.X = _reader.ReadSingle();
            t.PreboostStreamingRefPoint.Y = _reader.ReadSingle();
            t.PreboostStreamingRefPoint.Z = _reader.ReadSingle();

            t.PatchedNode = _reader.ReadUInt64();

            t.GlobalNodeId = new worldGlobalNodeID
            {
                Hash = _reader.ReadUInt64()
            };

            t.ProxyMeshId = new worldGlobalNodeID
            {
                Hash = _reader.ReadUInt64()
            };

            t.ExternalInplaceResourceHash = new CResourceReference<worldCookedPrefabData>(_reader.ReadUInt64());

            t.SecondaryRefPointDistance = _reader.ReadSingle();
            t.StreamingDistance = _reader.ReadSingle();

            var bits1 = _reader.ReadUInt64();
            t.NodeIdx = (uint)(bits1 & 0xFFFFF);
            t.NodeFlags = (Enums.ENodeFlags)((bits1 >> 20) & 0x1FFFFF);
            t.StreamingPriority = (byte)((bits1 >> 41) & 0xFF);

            var bits2 = _reader.ReadUInt64();
            t.TodvisMask = (ushort)(bits2 & 0xFFFF);

            t.DataGroup = (Enums.worldStreamingDataGroup)_reader.ReadByte();

            var bytes = _reader.ReadBytes(7); // padding
            if (bytes.Any(b => b != 0))
            {
                throw new Exception("Non-zero padding bytes found");
            }

            if (!data.Lookup.ContainsKey(t.NodeIdx))
            {
                data.Lookup[t.NodeIdx] = new();
            }
            data.Lookup[t.NodeIdx].Add(t);
            data.Add(t);
        }

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

        buffer.Data = data;

        return EFileReadErrorCodes.NoError;
    }
}
