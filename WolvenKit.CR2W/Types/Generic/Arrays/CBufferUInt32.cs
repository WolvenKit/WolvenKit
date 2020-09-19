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
    public class CBufferUInt32<T> : CBufferBase<T> where T : CVariable
    {
        public CBufferUInt32(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBufferUInt32<T>(cr2w, parent, name);

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size, (int)file.ReadUInt32());
        }

        public override void Write(BinaryWriter file)
        {
            CUInt32 count = new CUInt32(cr2w, null, "")
            {
                val = (uint)elements.Count
            };
            count.Write(file);

            base.Write(file);
        }
    }
}