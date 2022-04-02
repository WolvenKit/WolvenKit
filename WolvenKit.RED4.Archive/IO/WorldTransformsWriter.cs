using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Archive.IO
{
    public class WorldTransformsWriter : Red4Writer
    {
        public WorldTransformsWriter(Stream ms) : base(ms)
        {

        }

        public void WriteBuffer(WorldTransformsBuffer wsb)
        {
            foreach (var t in wsb.Transforms)
            {
                _writer.Write(t.Position.X);
                _writer.Write(t.Position.Y);
                _writer.Write(t.Position.Z);
                //_writer.Write(t.Position.W);

                _writer.Write(t.Orientation.I);
                _writer.Write(t.Orientation.J);
                _writer.Write(t.Orientation.K);
                _writer.Write(t.Orientation.R);

                if (t is WorldTransformExt a)
                {
                    _writer.Write(a.Scale.X);
                    _writer.Write(a.Scale.Y);
                    _writer.Write(a.Scale.Z);
                }
            }
        }
    }
}
