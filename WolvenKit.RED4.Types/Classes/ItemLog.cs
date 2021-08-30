using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemLog : gameuiMenuGameController
	{
		private inkCompoundWidgetReference _listRef;
		private CFloat _initialPopupDelay;
		private CArray<CWeakHandle<DisassemblePopupLogicController>> _popupList;
		private CArray<InventoryItemData> _listOfAddedInventoryItems;
		private CWeakHandle<PlayerPuppet> _player;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private CHandle<ItemLogUserData> _data;
		private CInt32 _onScreenCount;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private inkanimPlaybackOptions _animOptions;

		[Ordinal(3)] 
		[RED("listRef")] 
		public inkCompoundWidgetReference ListRef
		{
			get => GetProperty(ref _listRef);
			set => SetProperty(ref _listRef, value);
		}

		[Ordinal(4)] 
		[RED("initialPopupDelay")] 
		public CFloat InitialPopupDelay
		{
			get => GetProperty(ref _initialPopupDelay);
			set => SetProperty(ref _initialPopupDelay, value);
		}

		[Ordinal(5)] 
		[RED("popupList")] 
		public CArray<CWeakHandle<DisassemblePopupLogicController>> PopupList
		{
			get => GetProperty(ref _popupList);
			set => SetProperty(ref _popupList, value);
		}

		[Ordinal(6)] 
		[RED("listOfAddedInventoryItems")] 
		public CArray<InventoryItemData> ListOfAddedInventoryItems
		{
			get => GetProperty(ref _listOfAddedInventoryItems);
			set => SetProperty(ref _listOfAddedInventoryItems, value);
		}

		[Ordinal(7)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(8)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<ItemLogUserData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(10)] 
		[RED("onScreenCount")] 
		public CInt32 OnScreenCount
		{
			get => GetProperty(ref _onScreenCount);
			set => SetProperty(ref _onScreenCount, value);
		}

		[Ordinal(11)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(12)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetProperty(ref _alpha_fadein);
			set => SetProperty(ref _alpha_fadein, value);
		}

		[Ordinal(13)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		public ItemLog()
		{
			_initialPopupDelay = 1.000000F;
		}
	}
}
