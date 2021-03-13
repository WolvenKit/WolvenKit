using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class CMesh : CMesh_
    {
        [Ordinal(1)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }
        [Ordinal(5)] [RED("consoleBias")] public CUInt8 ConsoleBias { get; set; }
        [Ordinal(21)] [RED("saveDateTime")] public CDateTime SaveDateTime { get; set; }
        [Ordinal(997)] [RED("geometryHash")] public CUInt64 GeometryHash { get; set; }

        public CMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
