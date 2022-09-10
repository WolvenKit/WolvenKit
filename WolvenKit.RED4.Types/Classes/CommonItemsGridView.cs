using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CommonItemsGridView : inkScriptableDataViewWrapper
	{
		[Ordinal(0)] 
		[RED("itemFilterType")] 
		public CEnum<ItemFilterCategory> ItemFilterType
		{
			get => GetPropertyValue<CEnum<ItemFilterCategory>>();
			set => SetPropertyValue<CEnum<ItemFilterCategory>>(value);
		}

		[Ordinal(1)] 
		[RED("itemSortMode")] 
		public CEnum<ItemSortMode> ItemSortMode
		{
			get => GetPropertyValue<CEnum<ItemSortMode>>();
			set => SetPropertyValue<CEnum<ItemSortMode>>(value);
		}

		[Ordinal(2)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		public CommonItemsGridView()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
