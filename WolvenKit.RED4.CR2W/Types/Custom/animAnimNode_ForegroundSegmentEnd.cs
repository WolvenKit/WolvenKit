using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_ForegroundSegmentEnd : animAnimNode_ForegroundSegmentEnd_
    {
        [Ordinal(991)] [RED("segmentBeginNodeId")] public CUInt32 SegmentBeginNodeId { get; set; }

        public animAnimNode_ForegroundSegmentEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
