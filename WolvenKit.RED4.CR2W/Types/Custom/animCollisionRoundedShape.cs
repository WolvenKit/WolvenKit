using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animCollisionRoundedShape : animCollisionRoundedShape_
    {
        private CBool _drawAxis;

        [Ordinal(999)]
        [RED("drawAxis")]
        public CBool DrawAxis
        {
            get => GetProperty(ref _drawAxis);
            set => SetProperty(ref _drawAxis, value);
        }

        public animCollisionRoundedShape(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
