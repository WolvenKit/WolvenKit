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
    public class StreamingSectorTransformWriter : Red4Writer
    {
        public StreamingSectorTransformWriter(Stream ms) : base(ms)
        {

        }

        public void WriteBuffer(StreamingSectorBuffer ssb)
        {
            foreach (var t in ssb.AllTransforms)
            {
                _writer.Write(t.Position.X);
                _writer.Write(t.Position.Y);
                _writer.Write(t.Position.Z);
                _writer.Write(t.Position.W);

                _writer.Write(t.Orientation.I);
                _writer.Write(t.Orientation.J);
                _writer.Write(t.Orientation.K);
                _writer.Write(t.Orientation.R);

                _writer.Write(t.Scale.X);
                _writer.Write(t.Scale.Y);
                _writer.Write(t.Scale.Z);

                _writer.Write(t.Pivot.X);
                _writer.Write(t.Pivot.Y);
                _writer.Write(t.Pivot.Z);

                _writer.Write(t.Uk2.X);
                _writer.Write(t.Uk2.Y);
                _writer.Write(t.Uk2.Z);

                _writer.Write(t.Uk3.X);
                _writer.Write(t.Uk3.Y);
                _writer.Write(t.Uk3.Z);

                _writer.Write(t.Id);

                _writer.Write((ulong)t.QuestPrefabRefHash);
                _writer.Write((ulong)t.UkHash1);
                _writer.Write((ulong)t.UkHash2);

                _writer.Write(t.MaxStreamingDistance);
                _writer.Write(t.VariantID);

                _writer.Write(t.HandleIndex);
                _writer.Write(t.Uk10);
                _writer.Write(t.Uk11);
                _writer.Write(t.Uk12);
            }
        }
    }
}
