using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class MorphTargetMesh : MorphTargetMesh_
    {
        [Ordinal(999)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }

        public MorphTargetMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
