using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_StackTransformsShrinker : animAnimNode_StackTransformsShrinker_
    {
        private CUInt32 _extenderNodeId;

        [Ordinal(999)]
        [RED("extenderNodeId")]
        public CUInt32 ExtenderNodeId
        {
            get => GetProperty(ref _extenderNodeId);
            set => SetProperty(ref _extenderNodeId, value);
        }

        public animAnimNode_StackTransformsShrinker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
