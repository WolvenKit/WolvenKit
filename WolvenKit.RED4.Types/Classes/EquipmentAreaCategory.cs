using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentAreaCategory : IScriptable
	{
		private CWeakHandle<InventoryItemDisplayCategoryArea> _parentCategory;
		private CArray<CHandle<EquipmentAreaDisplays>> _areaDisplays;

		[Ordinal(0)] 
		[RED("parentCategory")] 
		public CWeakHandle<InventoryItemDisplayCategoryArea> ParentCategory
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
	}
}
