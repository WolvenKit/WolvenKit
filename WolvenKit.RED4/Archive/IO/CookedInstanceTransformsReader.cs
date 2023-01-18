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
    public partial class WorldSharedDataBufferReader
    { 
        public EFileReadErrorCodes ReadCookedInstanceTransformsBuffer(RedBuffer buffer)
        {
            var data = new CookedInstanceTransformsBuffer();
            while (_reader.BaseStream.Position < _reader.BaseStream.Length)
            {
                var t = new Transform();

                t.Position.X = _reader.ReadSingle();
                t.Position.Y = _reader.ReadSingle();
                t.Position.Z = _reader.ReadSingle();
                t.Position.W = _reader.ReadSingle();

                t.Orientation.I = _reader.ReadSingle();
                t.Orientation.J = _reader.ReadSingle();
                t.Orientation.K = _reader.ReadSingle();
                t.Orientation.R = _reader.ReadSingle();

                data.Transforms.Add(t);
            }
            buffer.Data = data;

            return EFileReadErrorCodes.NoError;
        }
    }
}
