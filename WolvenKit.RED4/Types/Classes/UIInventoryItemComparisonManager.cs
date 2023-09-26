using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemComparisonManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("ComparedStats")] 
		public CArray<CHandle<UIInventoryItemStatComparison>> ComparedStats
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItemStatComparison>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItemStatComparison>>>(value);
		}

		[Ordinal(1)] 
		[RED("ComparedItem")] 
		public CWeakHandle<UIInventoryItem> ComparedItem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonHash")] 
		public CUInt64 ComparisonHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public UIInventoryItemComparisonManager()
		{
			ComparedStats = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
