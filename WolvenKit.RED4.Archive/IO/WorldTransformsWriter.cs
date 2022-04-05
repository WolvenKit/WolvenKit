using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO
{
    public class WorldTransformsWriter : Red4Writer
    {
        public WorldTransformsWriter(MemoryStream ms) : base(ms)
        {

        }

        public void WriteBuffer(WorldTransformsBuffer wtb)
        {
            foreach (var t in wtb.Transforms)
            {
                _writer.Write(t.Position.X.Bits);
                _writer.Write(t.Position.Y.Bits);
                _writer.Write(t.Position.Z.Bits);
                _writer.Write(0);

                _writer.Write(t.Orientation.I);
                _writer.Write(t.Orientation.J);
                _writer.Write(t.Orientation.K);
                _writer.Write(t.Orientation.R);

                if (t is WorldTransformExt wte)
                {
                    _writer.Write(wte.Scale.X);
                    _writer.Write(wte.Scale.Y);
                    _writer.Write(wte.Scale.Z);
                    _writer.Write(0);
                }
            }
        }
    }
}
