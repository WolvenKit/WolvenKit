using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimVariable : animAnimVariable_
    {
        [Ordinal(1)] [RED("enableDebug")] public CBool EnableDebug { get; set; }

        public animAnimVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
