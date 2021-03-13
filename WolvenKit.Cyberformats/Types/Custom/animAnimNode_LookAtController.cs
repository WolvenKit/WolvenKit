using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_LookAtController : animAnimNode_LookAtController_
    {
        [Ordinal(1002)] [RED("debugDrawingEnabled")] public CBool DebugDrawingEnabled { get; set; }

        public animAnimNode_LookAtController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
