using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animDyngParticle : animDyngParticle_
    {
        [Ordinal(999)] [RED("isDebugEnabled")] public CBool IsDebugEnabled { get; set; }

        public animDyngParticle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
