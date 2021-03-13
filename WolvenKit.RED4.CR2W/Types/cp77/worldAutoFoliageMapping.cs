using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAutoFoliageMapping : CResource
	{
		[Ordinal(1)] [RED("Items")] public CArray<worldAutoFoliageMappingItem> Items { get; set; }

		public worldAutoFoliageMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
