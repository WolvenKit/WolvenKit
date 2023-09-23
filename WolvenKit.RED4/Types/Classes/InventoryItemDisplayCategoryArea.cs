using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemDisplayCategoryArea : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("areasToHide")] 
		public CArray<inkWidgetReference> AreasToHide
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(2)] 
		[RED("equipmentAreas")] 
		public CArray<inkCompoundWidgetReference> EquipmentAreas
		{
			get => GetPropertyValue<CArray<inkCompoundWidgetReference>>();
			set => SetPropertyValue<CArray<inkCompoundWidgetReference>>(value);
		}

		[Ordinal(3)] 
		[RED("newItemsWrapper")] 
		public inkWidgetReference NewItemsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("newItemsCounter")] 
		public inkTextWidgetReference NewItemsCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("categoryAreas")] 
		public CArray<CWeakHandle<InventoryItemDisplayEquipmentArea>> CategoryAreas
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayEquipmentArea>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayEquipmentArea>>>(value);
		}

		public InventoryItemDisplayCategoryArea()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
