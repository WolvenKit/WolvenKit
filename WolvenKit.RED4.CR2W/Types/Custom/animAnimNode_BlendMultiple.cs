using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_BlendMultiple : animAnimNode_BlendMultiple_
    {
        private CBool _debug;

        [Ordinal(999)]
        [RED("debug")]
        public CBool Debug
        {
            get => GetProperty(ref _debug);
            set => SetProperty(ref _debug, value);
        }

        public animAnimNode_BlendMultiple(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
