using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class CMesh : CMesh_
    {
        [Ordinal(4)] [RED("consoleBias")] public CUInt8 ConsoleBias { get; set; }
        [Ordinal(20)] [RED("saveDateTime")] public CDateTime SaveDateTime { get; set; }

        public CMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
