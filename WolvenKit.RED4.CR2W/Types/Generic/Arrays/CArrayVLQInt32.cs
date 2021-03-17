using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta()]
    public class CArrayVLQInt32<T> : CArrayBase<T> where T : CVariable
    {
        public CArrayVLQInt32(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size, (int)file.ReadVLQInt32());

        public override void Write(BinaryWriter file)
        {
            if (Elements == null)
                file.Write((byte) 0x80);
            else if (Elements.Count == 0)
                file.Write((byte) 0x00);
            else
                file.WriteVLQInt32(Elements.Count);

            base.Write(file);
        }
    }

    
}
