using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animIDyngConstraint : animIDyngConstraint_
    {
        [Ordinal(0)] [RED("isDebugEnabled")] public CBool IsDebugEnabled { get; set; }

        public animIDyngConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
