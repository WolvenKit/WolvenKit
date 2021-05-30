using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using WolvenKit.RED3.CR2W.Reflection;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta()]
    public class CBufferUInt16<T> : CBufferBase<T> where T : CVariable
    {
        public CBufferUInt16(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        

        public override void Read(BinaryReader file, uint size)
        {
            CUInt16 count = new CUInt16(cr2w, null, "");
            count.Read(file, size);

            base.Read(file, size, (int)count.val);
        }

        public override void Write(BinaryWriter file)
        {
            CUInt16 count = new CUInt16(cr2w, null, "");
            count.val = (ushort)elements.Count;
            count.Write(file);

            base.Write(file);
        }
    }
}