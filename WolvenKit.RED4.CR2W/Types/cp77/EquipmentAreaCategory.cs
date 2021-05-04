using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentAreaCategory : IScriptable
	{
		private CHandle<InventoryItemDisplayCategoryArea> _parentCategory;
		private CArray<CHandle<EquipmentAreaDisplays>> _areaDisplays;

		[Ordinal(0)] 
		[RED("parentCategory")] 
		public CHandle<InventoryItemDisplayCategoryArea> ParentCategory
		{
			get => GetProperty(ref _parentCategory);
			set => SetProperty(ref _parentCategory, value);
		}

		[Ordinal(1)] 
		[RED("areaDisplays")] 
		public CArray<CHandle<EquipmentAreaDisplays>> AreaDisplays
		{
			get => GetProperty(ref _areaDisplays);
			set => SetProperty(ref _areaDisplays, value);
		}

		public EquipmentAreaCategory(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
