using System.Collections.Generic;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class animRig : IRedAppendix
    {
        [RED("unk1")]
        [REDProperty(IsIgnored = true)]
        public CArray<CInt16> Unk1
        {
            get => GetPropertyValue<CArray<CInt16>>();
            set => SetPropertyValue<CArray<CInt16>>(value);
        }

        // could be anything, the vector4 is just a wild guess
        [RED("unk2")]
        [REDProperty(IsIgnored = true)]
        public CArray<CArray<Vector4>> Unk2
        {
            get => GetPropertyValue<CArray<CArray<Vector4>>>();
            set => SetPropertyValue<CArray<CArray<Vector4>>>(value);
        }

        public void Read(Red4Reader reader, uint size)
        {
            Unk1 = new CArray<CInt16>();
            Unk2 = new CArray<CArray<Vector4>>();

            var count = BoneNames.Count;
            for (var i = 0; i < count; i++)
            {
                Unk1.Add(reader.ReadCInt16());
            }

            for (var i = 0; i < count; i++)
            {
                var innerlist = new CArray<Vector4>();
                for (var j = 0; j < 3; j++)
                {
                    var vec = new Vector4()
                    {
                        X = reader.ReadCFloat(),
                        Y = reader.ReadCFloat(),
                        Z = reader.ReadCFloat(),
                        W = reader.ReadCFloat(),
                    };
                    innerlist.Add(vec);
                }
                Unk2.Add(innerlist);
            }
        }

        public void Write(Red4Writer writer)
        {
            foreach (var e in Unk1)
            {
                writer.Write(e);
            }

            foreach (var innerlist in Unk2)
            {
                foreach (var e3 in innerlist)
                {
                    writer.Write(e3.X);
                    writer.Write(e3.Y);
                    writer.Write(e3.Z);
                    writer.Write(e3.W);
                }
            }
        }
    }
}
