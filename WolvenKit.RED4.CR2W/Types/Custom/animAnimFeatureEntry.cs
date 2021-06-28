using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimFeatureEntry : animAnimFeatureEntry_
    {
        private CBool _debugEnabled;

        [Ordinal(999)]
        [RED("debugEnabled")]
        public CBool DebugEnabled
        {
            get => GetProperty(ref _debugEnabled);
            set => SetProperty(ref _debugEnabled, value);
        }

        public animAnimFeatureEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
