using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class EnumWrapper<T> : CName 
    {
        


        public EnumWrapper(CR2WFile cr2w) : base(cr2w) { }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
        }
    }
}