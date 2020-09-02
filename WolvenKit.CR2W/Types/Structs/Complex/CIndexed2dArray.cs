using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    class CIndexed2dArray : CVariable
    {
        [Ordinal(0)] [RED("headers", 12, 0)] public CArray<CString> Headers { get; set; }
        [Ordinal(1)] [RED("data", 12, 0, 12, 0)] public CArray<CArray<CString>> Data { get; set; }

        [Ordinal(1001)] [REDBuffer] public CBufferVLQInt32<CString> Strings1 { get; set; }
        [Ordinal(1002)] [REDBuffer] public CBufferVLQInt32<CBufferVLQInt32<CString>> Strings2 { get; set; }

        public CIndexed2dArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);
    }
}
