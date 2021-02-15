using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_SkAnim : animAnimNode_SkAnim_
    {
        [Ordinal(998)] [RED("debug")] public CBool Debug { get; set; }
        [Ordinal(999)] [RED("debugFootsteps")] public CBool DebugFootsteps { get; set; }

        public animAnimNode_SkAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
