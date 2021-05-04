using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    public class animAnimNode_FloatTrackDirectConnConstraint : animAnimNode_FloatTrackDirectConnConstraint_
    {
        private CBool _debug;

        [Ordinal(1001)]
        [RED("debug")]
        public CBool Debug
        {
            get => GetProperty(ref _debug);
            set => SetProperty(ref _debug, value);
        }

        public animAnimNode_FloatTrackDirectConnConstraint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
