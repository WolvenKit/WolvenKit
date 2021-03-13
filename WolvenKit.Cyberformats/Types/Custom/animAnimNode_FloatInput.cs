using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_FloatInput : animAnimNode_FloatInput_
    {
        [Ordinal(999)] [RED("debugInput")] public CBool DebugInput { get; set; }

        public animAnimNode_FloatInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
