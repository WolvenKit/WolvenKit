using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemCategoryFliterManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("filtersToCheck")] 
		public CArray<CEnum<ItemFilterCategory>> FiltersToCheck
		{
			get => GetPropertyValue<CArray<CEnum<ItemFilterCategory>>>();
			set => SetPropertyValue<CArray<CEnum<ItemFilterCategory>>>(value);
		}

		[Ordinal(1)] 
		[RED("filters")] 
		public CArray<CEnum<ItemFilterCategory>> Filters
		{
			get => GetPropertyValue<CArray<CEnum<ItemFilterCategory>>>();
			set => SetPropertyValue<CArray<CEnum<ItemFilterCategory>>>(value);
		}

		[Ordinal(2)] 
		[RED("sharedFiltersToCheck")] 
		public CArray<CEnum<ItemFilterCategory>> SharedFiltersToCheck
		{
			get => GetPropertyValue<CArray<CEnum<ItemFilterCategory>>>();
			set => SetPropertyValue<CArray<CEnum<ItemFilterCategory>>>(value);
		}

		[Ordinal(3)] 
		[RED("isOrderDirty")] 
		public CBool IsOrderDirty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemCategoryFliterManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
