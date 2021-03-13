using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_BlendFromPose : animAnimNode_BlendFromPose_
    {
        [Ordinal(998)] [RED("debug")] public CBool Debug { get; set; }

        public animAnimNode_BlendFromPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
