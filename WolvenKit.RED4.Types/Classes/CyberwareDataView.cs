using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CyberwareDataView : inkScriptableDataViewWrapper
	{
		private CEnum<RipperdocFilter> _itemFilterType;
		private CEnum<ItemSortMode> _itemSortMode;
		private CWeakHandle<UIScriptableSystem> _uiScriptableSystem;

		[Ordinal(0)] 
		[RED("itemFilterType")] 
		public CEnum<RipperdocFilter> ItemFilterType
		{
			get => GetProperty(ref _itemFilterType);
			set => SetProperty(ref _itemFilterType, value);
		}

		[Ordinal(1)] 
		[RED("itemSortMode")] 
		public CEnum<ItemSortMode> ItemSortMode
		{
			get => GetProperty(ref _itemSortMode);
			set => SetProperty(ref _itemSortMode, value);
		}

		[Ordinal(2)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}
	}
}
