using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemDisplayInventoryMiniGrid : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("gridList")] 
		public inkCompoundWidgetReference GridList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("gridWidth")] 
		public CInt32 GridWidth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("gridData")] 
		public CArray<CWeakHandle<InventoryItemDisplayController>> GridData
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplayController>>>(value);
		}

		public ItemDisplayInventoryMiniGrid()
		{
			GridList = new inkCompoundWidgetReference();
			Label = new inkTextWidgetReference();
			GridData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
