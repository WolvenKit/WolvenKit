using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipmentAreaCategory : IScriptable
	{
		[Ordinal(0)] 
		[RED("parentCategory")] 
		public CWeakHandle<InventoryItemDisplayCategoryArea> ParentCategory
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayCategoryArea>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayCategoryArea>>(value);
		}

		[Ordinal(1)] 
		[RED("areaDisplays")] 
		public CArray<CHandle<EquipmentAreaDisplays>> AreaDisplays
		{
			get => GetPropertyValue<CArray<CHandle<EquipmentAreaDisplays>>>();
			set => SetPropertyValue<CArray<CHandle<EquipmentAreaDisplays>>>(value);
		}

		public EquipmentAreaCategory()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
