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
    public class WorldTransformsReader : Red4Reader, IBufferReader
    {
        public WorldTransformsReader(MemoryStream ms) : base(ms)
        {

        }

        public EFileReadErrorCodes ReadBuffer(RedBuffer buffer, Type fileRootType)
        {
            var data = new WorldTransformsBuffer();

            while(_reader.BaseStream.Position < _reader.BaseStream.Length)
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

            buffer.Data = data;

            return EFileReadErrorCodes.NoError;
        }
    }
}
