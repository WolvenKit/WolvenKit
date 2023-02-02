using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemCompareBuilder : IScriptable
	{
		[Ordinal(0)] 
		[RED("sortData1")] 
		public CHandle<UIInventoryItem> SortData1
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(1)] 
		[RED("sortData2")] 
		public CHandle<UIInventoryItem> SortData2
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetPropertyValue<CHandle<CompareBuilder>>();
			set => SetPropertyValue<CHandle<CompareBuilder>>(value);
		}

		public NewItemCompareBuilder()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
