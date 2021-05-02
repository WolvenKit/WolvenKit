using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAutoFoliageMapping : CResource
	{
		private CArray<worldAutoFoliageMappingItem> _items;

		[Ordinal(1)] 
		[RED("Items")] 
		public CArray<worldAutoFoliageMappingItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public worldAutoFoliageMapping(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
