using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_StackTransformsExtender : animAnimNode_StackTransformsExtender_
    {
        [Ordinal(999)] [RED("shrinkerNodeId")] public CUInt32 ShrinkerNodeId { get; set; }

        public animAnimNode_StackTransformsExtender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
