using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta]
    public class CHelpTextComponent : CComponent
    {
        public CHelpTextComponent(CR2WFile cr2w) : base(cr2w) { }

        [RED("text")] public CString Text { get; set; }

        [RED("drawBackground")] public CBool DrawBackground { get; set; }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

    }
    
}