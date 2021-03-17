using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
	public class CMaterialInstance : CMaterialInstance_
	{
        private CArray<CVariantSizeNameType> _cMaterialInstanceData;

        [Ordinal(1000)]
        [REDBuffer]
        public CArray<CVariantSizeNameType> CMaterialInstanceData
        {
            get => GetProperty(ref _cMaterialInstanceData);
            set => SetProperty(ref _cMaterialInstanceData, value);
        }

        public CMaterialInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
