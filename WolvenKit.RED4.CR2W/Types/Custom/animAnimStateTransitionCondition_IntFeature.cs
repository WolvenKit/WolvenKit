using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimStateTransitionCondition_IntFeature : animAnimStateTransitionCondition_IntFeature_
    {
        private CBool _debugInput;

        [Ordinal(999)]
        [RED("debugInput")]
        public CBool DebugInput
        {
            get => GetProperty(ref _debugInput);
            set => SetProperty(ref _debugInput, value);
        }

        public animAnimStateTransitionCondition_IntFeature(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
