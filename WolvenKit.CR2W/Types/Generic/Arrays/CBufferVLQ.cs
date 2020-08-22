using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CBufferVLQ<T> : CBufferBase<T> where T : CVariable
    {
        public CBufferVLQ(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size, (int)file.ReadBit6());
        }

        public override void Write(BinaryWriter file)
        {
            CDynamicInt count = new CDynamicInt(cr2w, null, "")
            {
                val = elements.Count
            };
            count.Write(file);

            base.Write(file);
        }


        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBufferVLQ<T>(cr2w, parent, name);
    }
}