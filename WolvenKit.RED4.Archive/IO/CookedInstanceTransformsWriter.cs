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
    public class CookedInstanceTransformsWriter : Red4Writer
    {
        public CookedInstanceTransformsWriter(MemoryStream ms) : base(ms)
        {

        }

        public void WriteBuffer(CookedInstanceTransformsBuffer citb)
        {
            foreach (var tr in citb.Transforms)
            {
                _writer.Write(tr.Position.X);
                _writer.Write(tr.Position.Y);
                _writer.Write(tr.Position.Z);
                _writer.Write(tr.Position.W);

                _writer.Write(tr.Orientation.I);
                _writer.Write(tr.Orientation.J);
                _writer.Write(tr.Orientation.K);
                _writer.Write(tr.Orientation.R);
            }
        }
    }
}
