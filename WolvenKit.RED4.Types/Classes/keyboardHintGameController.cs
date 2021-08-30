using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class keyboardHintGameController : gameuiHUDGameController
	{
		private CName _topElementName;
		private CName _bottomElementName;
		private inkBasePanelWidgetReference _layout;
		private CArray<CWeakHandle<KeyboardHintItemController>> _uIItems;
		private CWeakHandle<PlayerPuppet> _player;
		private CWeakHandle<QuickSlotsManager> _quickSlotsManager;
		private CWeakHandle<gameIBlackboard> _uiQuickItemsBlackboard;
		private CHandle<redCallbackObject> _keyboardCommandBBID;

		[Ordinal(9)] 
		[RED("TopElementName")] 
		public CName TopElementName
		{
			get => GetProperty(ref _topElementName);
			set => SetProperty(ref _topElementName, value);
		}

		[Ordinal(10)] 
		[RED("BottomElementName")] 
		public CName BottomElementName
		{
			get => GetProperty(ref _bottomElementName);
			set => SetProperty(ref _bottomElementName, value);
		}

		[Ordinal(11)] 
		[RED("Layout")] 
		public inkBasePanelWidgetReference Layout
		{
			get => GetProperty(ref _layout);
			set => SetProperty(ref _layout, value);
		}

		[Ordinal(12)] 
		[RED("UIItems")] 
		public CArray<CWeakHandle<KeyboardHintItemController>> UIItems
		{
			get => GetProperty(ref _uIItems);
			set => SetProperty(ref _uIItems, value);
		}

		[Ordinal(13)] 
		[RED("Player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(14)] 
		[RED("QuickSlotsManager")] 
		public CWeakHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetProperty(ref _quickSlotsManager);
			set => SetProperty(ref _quickSlotsManager, value);
		}

		[Ordinal(15)] 
		[RED("UiQuickItemsBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiQuickItemsBlackboard
		{
			get => GetProperty(ref _uiQuickItemsBlackboard);
			set => SetProperty(ref _uiQuickItemsBlackboard, value);
		}

		[Ordinal(16)] 
		[RED("KeyboardCommandBBID")] 
		public CHandle<redCallbackObject> KeyboardCommandBBID
		{
			get => GetProperty(ref _keyboardCommandBBID);
			set => SetProperty(ref _keyboardCommandBBID, value);
		}

		public keyboardHintGameController()
		{
			_topElementName = "KeyboardHintItem_Top";
			_bottomElementName = "KeyboardHintItem_Bot";
		}
	}
}
