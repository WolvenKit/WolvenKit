using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animCollisionRoundedShape : animCollisionRoundedShape_
    {
        [Ordinal(999)] [RED("drawAxis")] public CBool DrawAxis { get; set; }

        public animCollisionRoundedShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
