using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animLookAtPartInfo : animLookAtPartInfo_
    {
        private CBool _debugDrawingEnabled;

        [Ordinal(1002)]
        [RED("debugDrawingEnabled")]
        public CBool DebugDrawingEnabled
        {
            get => GetProperty(ref _debugDrawingEnabled);
            set => SetProperty(ref _debugDrawingEnabled, value);
        }

        public animLookAtPartInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
