using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animDangleConstraint_SimulationDyng : animDangleConstraint_SimulationDyng_
    {
        [Ordinal(999)] [RED("drawDebugConstraint")] public CBool DrawDebugConstraint { get; set; }

        public animDangleConstraint_SimulationDyng(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
