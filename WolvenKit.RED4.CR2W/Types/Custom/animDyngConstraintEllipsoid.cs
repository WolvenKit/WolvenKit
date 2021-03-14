using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animDyngConstraintEllipsoid : animDyngConstraintEllipsoid_
    {
        [Ordinal(996)] [RED("drawDebugConstraint")] public CBool DrawDebugConstraint { get; set; }

        public animDyngConstraintEllipsoid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
