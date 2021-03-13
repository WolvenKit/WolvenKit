using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimStateTransitionInterpolator_Blend : animAnimStateTransitionInterpolator_Blend_
    {
        [Ordinal(999)] [RED("visTransitionDuration")] public CFloat VisTransitionDuration { get; set; }

        public animAnimStateTransitionInterpolator_Blend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
