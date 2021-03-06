using System.Collections.Generic;
using System.IO;
using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class scnAnimName : scnAnimName_
    {
        [Ordinal(1000)] [REDBuffer(true)] public List<CName> Unk1 { get; set; }

        public scnAnimName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Unk1 = new List<CName>();
        }

        public override void Read(BinaryReader file, uint size)
        {
            var startPos = file.BaseStream.Position;
            base.Read(file, size);
            var count = (uint) (size - (file.BaseStream.Position - startPos)) / 2;

            for (int i = 0; i < count; i++)
            {
                var cname = new CName(cr2w, this, i.ToString());
                cname.Read(file, 2);
                Unk1.Add(cname);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            foreach (var cName in Unk1)
            {
                cName.Write(file);
            }
        }
    }
}
