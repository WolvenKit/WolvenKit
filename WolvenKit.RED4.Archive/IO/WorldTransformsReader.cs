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
    public class WorldTransformsReader : Red4Reader, IBufferReader
    {
        public WorldTransformsReader(MemoryStream ms) : base(ms)
        {

        }

        public EFileReadErrorCodes ReadBuffer(RedBuffer buffer, Type fileRootType)
        {
            var data = new WorldTransformsBuffer();
            if (buffer.RootChunk is worldStreamingSector sec)
            {
                foreach (var handle in sec.Handles)
                {
                    var value = handle.GetValue();
                    if (value is worldInstancedMeshNode node1
                        && node1.WorldTransformsBuffer.SharedDataBuffer.GetValue() is worldSharedDataBuffer sdb1
                        && ReferenceEquals(sdb1.Buffer.Buffer, buffer))
                    {
                        while (_reader.BaseStream.Position < _reader.BaseStream.Length)
                        {
                            var t = new WorldTransformExt();

                            t.Position.X.Bits = _reader.ReadInt32();
                            t.Position.Y.Bits = _reader.ReadInt32();
                            t.Position.Z.Bits = _reader.ReadInt32();

                            _reader.ReadInt32();

                            t.Orientation.I = _reader.ReadSingle();
                            t.Orientation.J = _reader.ReadSingle();
                            t.Orientation.K = _reader.ReadSingle();
                            t.Orientation.R = _reader.ReadSingle();

                            t.Scale.X = _reader.ReadSingle();
                            t.Scale.Y = _reader.ReadSingle();
                            t.Scale.Z = _reader.ReadSingle();

                            _reader.ReadInt32();

                            data.Transforms.Add(t);
                        }
                        break;
                    }

                    if (value is worldInstancedDestructibleMeshNode node2
                        && node2.CookedInstanceTransforms.SharedDataBuffer.GetValue() is worldSharedDataBuffer sdb2
                        && ReferenceEquals(sdb2.Buffer.Buffer, buffer))
                    {
                        while (_reader.BaseStream.Position < _reader.BaseStream.Length)
                        {
                            var t = new WorldTransform();

                            t.Position.X.Bits = _reader.ReadInt32();
                            t.Position.Y.Bits = _reader.ReadInt32();
                            t.Position.Z.Bits = _reader.ReadInt32();

                            _reader.ReadInt32();

                            t.Orientation.I = _reader.ReadSingle();
                            t.Orientation.J = _reader.ReadSingle();
                            t.Orientation.K = _reader.ReadSingle();
                            t.Orientation.R = _reader.ReadSingle();

                            data.Transforms.Add(t);
                        }
                        break;
                    }
                }
            }

            buffer.Data = data;

            return EFileReadErrorCodes.NoError;
        }
    }
}
