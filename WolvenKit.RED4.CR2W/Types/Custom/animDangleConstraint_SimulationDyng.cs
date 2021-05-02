using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animDangleConstraint_SimulationDyng : animDangleConstraint_SimulationDyng_
    {
        private CBool _drawDebugConstraint;

        [Ordinal(999)]
        [RED("drawDebugConstraint")]
        public CBool DrawDebugConstraint
        {
            get => GetProperty(ref _drawDebugConstraint);
            set => SetProperty(ref _drawDebugConstraint, value);
        }

        public animDangleConstraint_SimulationDyng(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
