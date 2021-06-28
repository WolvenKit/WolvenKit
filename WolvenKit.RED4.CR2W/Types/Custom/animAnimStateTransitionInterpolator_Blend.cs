using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimStateTransitionInterpolator_Blend : animAnimStateTransitionInterpolator_Blend_
    {
        private CFloat _visTransitionDuration;

        [Ordinal(999)]
        [RED("visTransitionDuration")]
        public CFloat VisTransitionDuration
        {
            get => GetProperty(ref _visTransitionDuration);
            set => SetProperty(ref _visTransitionDuration, value);
        }

        public animAnimStateTransitionInterpolator_Blend(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
