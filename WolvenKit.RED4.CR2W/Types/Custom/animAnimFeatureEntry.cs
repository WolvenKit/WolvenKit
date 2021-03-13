using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimFeatureEntry : animAnimFeatureEntry_
    {
        [Ordinal(999)] [RED("debugEnabled")] public CBool DebugEnabled { get; set; }

        public animAnimFeatureEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
