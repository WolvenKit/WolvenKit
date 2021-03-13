using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
	public class CMaterialInstance : CMaterialInstance_
	{
        [Ordinal(1000)] [REDBuffer] public CArray<CVariantSizeNameType> CMaterialInstanceData { get; set; }

        public CMaterialInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
