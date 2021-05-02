using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_ConditionalSegmentBegin : animAnimNode_ConditionalSegmentBegin_
    {
        private CUInt32 _segmentEndNodeId;

        [Ordinal(12)]
        [RED("segmentEndNodeId")]
        public CUInt32 SegmentEndNodeId
        {
            get => GetProperty(ref _segmentEndNodeId);
            set => SetProperty(ref _segmentEndNodeId, value);
        }

        public animAnimNode_ConditionalSegmentBegin(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
