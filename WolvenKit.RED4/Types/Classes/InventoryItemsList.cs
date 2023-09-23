using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemsList : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("InventoryItemName")] 
		public CName InventoryItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("ItemsLayoutRef")] 
		public inkCompoundWidgetReference ItemsLayoutRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("TooltipsData")] 
		public CArray<CHandle<ATooltipData>> TooltipsData
		{
			get => GetPropertyValue<CArray<CHandle<ATooltipData>>>();
			set => SetPropertyValue<CArray<CHandle<ATooltipData>>>(value);
		}

		[Ordinal(4)] 
		[RED("ItemsOwner")] 
		public CWeakHandle<gameObject> ItemsOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("ItemsLayout")] 
		public CWeakHandle<inkCompoundWidget> ItemsLayout
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(6)] 
		[RED("InventoryItems")] 
		public CArray<CWeakHandle<inkWidget>> InventoryItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(7)] 
		[RED("IsDevice")] 
		public CBool IsDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		public InventoryItemsList()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
