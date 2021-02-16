using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class scnAnimName : scnAnimName_
    {
        [Ordinal(1000)] [REDBuffer] public CUInt16 Unk1 { get; set; }

        public scnAnimName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
