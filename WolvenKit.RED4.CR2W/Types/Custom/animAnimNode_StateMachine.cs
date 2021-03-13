using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_StateMachine : animAnimNode_StateMachine_
    {
        [Ordinal(999)] [RED("debugFlag")] public CBool DebugFlag { get; set; }
        [Ordinal(1000)] [RED("debugName")] public CName DebugName { get; set; }

        public animAnimNode_StateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
