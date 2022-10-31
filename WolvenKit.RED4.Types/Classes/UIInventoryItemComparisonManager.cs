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

		public UIInventoryItemComparisonManager()
		{
			ComparedStats = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
