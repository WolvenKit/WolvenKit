using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animLookAtPartsDependency : animLookAtPartsDependency_
    {
        private CColor _innerSquareColor;
        private CColor _outerSquareColor;

        [Ordinal(998)]
        [RED("innerSquareColor")]
        public CColor InnerSquareColor
        {
            get => GetProperty(ref _innerSquareColor);
            set => SetProperty(ref _innerSquareColor, value);
        }

        [Ordinal(999)]
        [RED("outerSquareColor")]
        public CColor OuterSquareColor
        {
            get => GetProperty(ref _outerSquareColor);
            set => SetProperty(ref _outerSquareColor, value);
        }

        public animLookAtPartsDependency(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
