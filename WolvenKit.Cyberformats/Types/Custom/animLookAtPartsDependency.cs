using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animLookAtPartsDependency : animLookAtPartsDependency_
    {
        [Ordinal(998)] [RED("innerSquareColor")] public CColor InnerSquareColor { get; set; }
        [Ordinal(999)] [RED("outerSquareColor")] public CColor OuterSquareColor { get; set; }

        public animLookAtPartsDependency(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
