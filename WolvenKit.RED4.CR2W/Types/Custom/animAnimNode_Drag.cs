using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    public class animAnimNode_Drag : animAnimNode_Drag_
    {
        private CBool _debugDrawingEnabled;

        [Ordinal(16)]
        [RED("debugDrawingEnabled")]
        public CBool DebugDrawingEnabled
        {
            get => GetProperty(ref _debugDrawingEnabled);
            set => SetProperty(ref _debugDrawingEnabled, value);
        }

        public animAnimNode_Drag(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
