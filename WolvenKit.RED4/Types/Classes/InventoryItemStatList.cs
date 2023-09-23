using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemStatList : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("libraryItemName")] 
		public CName LibraryItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("container")] 
		public CWeakHandle<inkCompoundWidget> Container
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("data")] 
		public CArray<InventoryTooltipData_StatData> Data
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(4)] 
		[RED("itemsList")] 
		public CArray<CWeakHandle<inkWidget>> ItemsList
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		public InventoryItemStatList()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
