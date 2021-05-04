using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_ForegroundSegmentEnd : animAnimNode_ForegroundSegmentEnd_
    {
        private CUInt32 _segmentBeginNodeId;

        [Ordinal(991)]
        [RED("segmentBeginNodeId")]
        public CUInt32 SegmentBeginNodeId
        {
            get => GetProperty(ref _segmentBeginNodeId);
            set => SetProperty(ref _segmentBeginNodeId, value);
        }

        public animAnimNode_ForegroundSegmentEnd(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
