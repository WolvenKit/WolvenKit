using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animRig : animRig_
    {
        [Ordinal(999)] [RED("skipRigValidation")] public CBool SkipRigValidation { get; set; }

        public animRig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
