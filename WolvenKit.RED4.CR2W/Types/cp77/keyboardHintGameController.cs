using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class keyboardHintGameController : gameuiHUDGameController
	{
		private CName _topElementName;
		private CName _bottomElementName;
		private inkBasePanelWidgetReference _layout;
		private CArray<wCHandle<KeyboardHintItemController>> _uIItems;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<QuickSlotsManager> _quickSlotsManager;
		private CHandle<gameIBlackboard> _uiQuickItemsBlackboard;
		private CUInt32 _keyboardCommandBBID;

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
		public CArray<wCHandle<KeyboardHintItemController>> UIItems
		{
			get => GetProperty(ref _uIItems);
			set => SetProperty(ref _uIItems, value);
		}

		[Ordinal(13)] 
		[RED("Player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(14)] 
		[RED("QuickSlotsManager")] 
		public wCHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetProperty(ref _quickSlotsManager);
			set => SetProperty(ref _quickSlotsManager, value);
		}

		[Ordinal(15)] 
		[RED("UiQuickItemsBlackboard")] 
		public CHandle<gameIBlackboard> UiQuickItemsBlackboard
		{
			get => GetProperty(ref _uiQuickItemsBlackboard);
			set => SetProperty(ref _uiQuickItemsBlackboard, value);
		}

		[Ordinal(16)] 
		[RED("KeyboardCommandBBID")] 
		public CUInt32 KeyboardCommandBBID
		{
			get => GetProperty(ref _keyboardCommandBBID);
			set => SetProperty(ref _keyboardCommandBBID, value);
		}

		public keyboardHintGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
