using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_ConditionalSegmentEnd : animAnimNode_ConditionalSegmentEnd_
    {
        [Ordinal(999)] [RED("segmentBeginNodeId")] public CUInt32 SegmentBeginNodeId { get; set; }

        public animAnimNode_ConditionalSegmentEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
