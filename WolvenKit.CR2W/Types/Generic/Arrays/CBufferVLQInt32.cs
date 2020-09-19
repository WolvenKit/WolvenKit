using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CBufferVLQInt32<T> : CBufferBase<T> where T : CVariable
    {
        public CBufferVLQInt32(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size, (int)file.ReadVLQInt32());
        }

        public override void Write(BinaryWriter file)
        {
            if (elements.Count == 0)
            {
                file.Write((byte)0x80);
            }
            else
            {
                CVLQInt32 count = new CVLQInt32(cr2w, null, "");
                count.val = elements.Count;
                count.Write(file);
            }

            base.Write(file);
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBufferVLQInt32<T>(cr2w, parent, name);
    }

    
}