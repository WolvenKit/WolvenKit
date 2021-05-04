using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    public class animAnimNode_AddSnapToTerrainIkRequest : animAnimNode_AddSnapToTerrainIkRequest_
    {
        private CBool _debug;

        [Ordinal(12)]
        [RED("debug")]
        public CBool Debug
        {
            get => GetProperty(ref _debug);
            set => SetProperty(ref _debug, value);
        }

        public animAnimNode_AddSnapToTerrainIkRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
