using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_ConditionalSegmentBegin : animAnimNode_ConditionalSegmentBegin_
    {
        [Ordinal(991)] [RED("segmentEndNodeId")] public CUInt32 SegmentEndNodeId { get; set; }

        public animAnimNode_ConditionalSegmentBegin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
