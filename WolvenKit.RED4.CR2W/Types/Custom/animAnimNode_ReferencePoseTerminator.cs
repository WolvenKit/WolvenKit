using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_ReferencePoseTerminator : animAnimNode_ReferencePoseTerminator_
    {
        private CBool _visWhenActive1;

        [Ordinal(999)]
        [RED("visWhenActive")]
        public new CBool VisWhenActive
        {
            get => GetProperty(ref _visWhenActive1);
            set => SetProperty(ref _visWhenActive1, value);
        }

        public animAnimNode_ReferencePoseTerminator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
