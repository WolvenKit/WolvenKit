using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    public class animAnimNode_FloatTrackDirectConnConstraint : animAnimNode_FloatTrackDirectConnConstraint_
    {
        [Ordinal(1001)] [RED("debug")] public CBool Debug { get; set; }

        public animAnimNode_FloatTrackDirectConnConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
