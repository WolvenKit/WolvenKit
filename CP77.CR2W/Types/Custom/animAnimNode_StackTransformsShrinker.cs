using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_StackTransformsShrinker : animAnimNode_StackTransformsShrinker_
    {
        [Ordinal(999)] [RED("extenderNodeId")] public CUInt32 ExtenderNodeId { get; set; }

        public animAnimNode_StackTransformsShrinker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
