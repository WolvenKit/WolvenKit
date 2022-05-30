using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO
{
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
                t.CookedPrefabData.DepotPath = _reader.ReadUInt64();

                t.MaxStreamingDistance = _reader.ReadSingle();
                t.UkFloat1 = _reader.ReadSingle();

                t.NodeIndex = _reader.ReadUInt16();

                t.Uk10 = _reader.ReadUInt16();
                t.Uk11 = _reader.ReadUInt16();
                t.Uk12 = _reader.ReadUInt16();

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
}
