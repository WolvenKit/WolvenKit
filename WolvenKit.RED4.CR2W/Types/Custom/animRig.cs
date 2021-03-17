using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animRig : animRig_
    {
        private CBool _skipRigValidation;

        [Ordinal(999)]
        [RED("skipRigValidation")]
        public CBool SkipRigValidation
        {
            get => GetProperty(ref _skipRigValidation);
            set => SetProperty(ref _skipRigValidation, value);
        }

        public animRig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
