using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemInventoryMiniGrid : inkWidgetLogicController
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
		public CArray<CWeakHandle<InventoryItemDisplay>> GridData
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemDisplay>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemDisplay>>>(value);
		}

		public ItemInventoryMiniGrid()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
