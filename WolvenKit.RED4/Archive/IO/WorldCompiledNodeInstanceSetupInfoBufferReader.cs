using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;
public class WorldCompiledNodeInstanceSetupInfoBufferReader : Red4Reader, IBufferReader
{
    public WorldCompiledNodeInstanceSetupInfoBufferReader(MemoryStream ms) : base(ms)
    {

    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        var data = new worldCompiledNodeInstanceSetupInfoBuffer();

        while(_reader.BaseStream.Position < _reader.BaseStream.Length)
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

            // skip this as it should be the same as StreamingRefPoint
            _reader.BaseStream.Seek(12, SeekOrigin.Current);

            t.Id = _reader.ReadUInt64();
            t.GlobalNodeId.Hash = _reader.ReadUInt64();
            t.ProxyNodeId.Hash = _reader.ReadUInt64();
            t.CookedPrefabData = new CResourceReference<worldCookedPrefabData>(_reader.ReadUInt64());

            t.SecondaryRefPointDistance = _reader.ReadSingle();
            t.StreamingDistance = _reader.ReadSingle();

            t.NodeIndex = _reader.ReadUInt16();

            t.Uk11 = _reader.ReadUInt16();
            t.Uk12 = _reader.ReadUInt16();
            t.Uk13 = _reader.ReadUInt16();

            // TODO: [Path-2.0] Check if its right
            t.Uk14 = _reader.ReadUInt64();
            t.Uk15 = _reader.ReadUInt64();

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
