using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemTooltipWrapper : ATooltipData
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CWeakHandle<UIInventoryItem> Data
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItem>>(value);
		}

		[Ordinal(1)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetPropertyValue<CHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(2)] 
		[RED("overridePrice")] 
		public CInt32 OverridePrice
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("comparisonData")] 
		public CHandle<UIInventoryItemComparisonManager> ComparisonData
		{
			get => GetPropertyValue<CHandle<UIInventoryItemComparisonManager>>();
			set => SetPropertyValue<CHandle<UIInventoryItemComparisonManager>>(value);
		}

		public UIInventoryItemTooltipWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
