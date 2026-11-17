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

            // 2.5 and later
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

            // TODO: [Path-2.0] Check if its right
            //t.Uk13 = _reader.ReadUInt64();
            //t.Uk14 = _reader.ReadUInt64();

            if (!data.Lookup.ContainsKey(t.NodeIdx))
            {
                data.Lookup[t.NodeIdx] = new();
            }
            data.Lookup[t.NodeIdx].Add(t);
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

    public EFileReadErrorCodes ReadBufferOld(RedBuffer buffer)
    {
        var data = new worldNodeDataBuffer();

        while (_reader.BaseStream.Position < _reader.BaseStream.Length)
        {
            // some of this stuff could be worldNodeEditorData
            var t = new worldNodeData();

            t.Position.X = _reader.ReadSingle();
            t.Position.Y = _reader.ReadSingle();
            t.Position.Z = _reader.ReadSingle();
            t.Position.W = _reader.ReadSingle();

            t.Orientation.I = _reader.ReadSingle();
            t.Orientation.J = _reader.ReadSingle();
            t.Orientation.K = _reader.ReadSingle();
            t.Orientation.R = _reader.ReadSingle();

            t.Scale.X = _reader.ReadSingle();
            t.Scale.Y = _reader.ReadSingle();
            t.Scale.Z = _reader.ReadSingle();

            t.Pivot.X = _reader.ReadSingle();
            t.Pivot.Y = _reader.ReadSingle();
            t.Pivot.Z = _reader.ReadSingle();

            t.Bounds.Min.X = _reader.ReadSingle();
            t.Bounds.Min.Y = _reader.ReadSingle();
            t.Bounds.Min.Z = _reader.ReadSingle();

            t.Bounds.Max.X = _reader.ReadSingle();
            t.Bounds.Max.Y = _reader.ReadSingle();
            t.Bounds.Max.Z = _reader.ReadSingle();

            t.Id = _reader.ReadUInt64();

            t.QuestPrefabRefHash = _reader.ReadUInt64();
            t.UkHash1 = _reader.ReadUInt64();
            t.CookedPrefabData = new CResourceReference<worldCookedPrefabData>(_reader.ReadUInt64());

            t.MaxStreamingDistance = _reader.ReadSingle();
            t.UkFloat1 = _reader.ReadSingle();

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
            //data.Lookup[t.NodeIndex].Add(t);
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
