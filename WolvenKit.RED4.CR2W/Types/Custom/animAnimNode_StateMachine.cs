using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_StateMachine : animAnimNode_StateMachine_
    {
        private CBool _debugFlag;
        private CName _debugName1;

        [Ordinal(999)]
        [RED("debugFlag")]
        public CBool DebugFlag
        {
            get => GetProperty(ref _debugFlag);
            set => SetProperty(ref _debugFlag, value);
        }

        [Ordinal(1000)]
        [RED("debugName")]
        public CName DebugName
        {
            get => GetProperty(ref _debugName1);
            set => SetProperty(ref _debugName1, value);
        }

        public animAnimNode_StateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
