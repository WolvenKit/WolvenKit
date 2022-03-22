using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.Archive.IO
{
    public class StreamingSectorTransformReader : Red4Reader, IBufferReader
    {
        public StreamingSectorTransformReader(MemoryStream ms) : base(ms)
        {

        }

        public EFileReadErrorCodes ReadBuffer(RedBuffer buffer, Type fileRootType)
        {
            var data = new StreamingSectorBuffer();

            while (_reader.BaseStream.Position < _reader.BaseStream.Length)
            {
                var t = new StreamingSectorTransform();

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

                t.Uk1.X = _reader.ReadSingle();
                t.Uk1.Y = _reader.ReadSingle();
                t.Uk1.Z = _reader.ReadSingle();

                t.Uk2.X = _reader.ReadSingle();
                t.Uk2.Y = _reader.ReadSingle();
                t.Uk2.Z = _reader.ReadSingle();

                t.Uk3.X = _reader.ReadSingle();
                t.Uk3.Y = _reader.ReadSingle();
                t.Uk3.Z = _reader.ReadSingle();

                t.Uk4 = _reader.ReadInt32();
                t.Uk5 = _reader.ReadInt32();

                // possible padding?
                _reader.ReadBytes(24);

                t.Mask = _reader.ReadUInt64();
                t.HandleIndex = _reader.ReadUInt16();
                t.Uk6 = _reader.ReadUInt16();
                t.Uk7 = _reader.ReadUInt16();
                t.Uk8 = _reader.ReadUInt16();

                if (!data.Transforms.ContainsKey(t.HandleIndex))
                {
                    data.Transforms[t.HandleIndex] = new();
                }
                data.Transforms[t.HandleIndex].Add(t);
                data.AllTransforms.Add(t);
            }

            buffer.Data = data;

            return EFileReadErrorCodes.NoError;
        }
    }
}
