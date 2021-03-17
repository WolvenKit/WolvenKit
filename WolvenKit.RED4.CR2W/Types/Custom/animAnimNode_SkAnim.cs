using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_SkAnim : animAnimNode_SkAnim_
    {
        private CBool _debug;
        private CBool _debugFootsteps;

        [Ordinal(28)]
        [RED("debug")]
        public CBool Debug
        {
            get => GetProperty(ref _debug);
            set => SetProperty(ref _debug, value);
        }

        [Ordinal(29)]
        [RED("debugFootsteps")]
        public CBool DebugFootsteps
        {
            get => GetProperty(ref _debugFootsteps);
            set => SetProperty(ref _debugFootsteps, value);
        }

        public animAnimNode_SkAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
