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
			get
			{
				if (_topElementName == null)
				{
					_topElementName = (CName) CR2WTypeManager.Create("CName", "TopElementName", cr2w, this);
				}
				return _topElementName;
			}
			set
			{
				if (_topElementName == value)
				{
					return;
				}
				_topElementName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("BottomElementName")] 
		public CName BottomElementName
		{
			get
			{
				if (_bottomElementName == null)
				{
					_bottomElementName = (CName) CR2WTypeManager.Create("CName", "BottomElementName", cr2w, this);
				}
				return _bottomElementName;
			}
			set
			{
				if (_bottomElementName == value)
				{
					return;
				}
				_bottomElementName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("Layout")] 
		public inkBasePanelWidgetReference Layout
		{
			get
			{
				if (_layout == null)
				{
					_layout = (inkBasePanelWidgetReference) CR2WTypeManager.Create("inkBasePanelWidgetReference", "Layout", cr2w, this);
				}
				return _layout;
			}
			set
			{
				if (_layout == value)
				{
					return;
				}
				_layout = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("UIItems")] 
		public CArray<wCHandle<KeyboardHintItemController>> UIItems
		{
			get
			{
				if (_uIItems == null)
				{
					_uIItems = (CArray<wCHandle<KeyboardHintItemController>>) CR2WTypeManager.Create("array:whandle:KeyboardHintItemController", "UIItems", cr2w, this);
				}
				return _uIItems;
			}
			set
			{
				if (_uIItems == value)
				{
					return;
				}
				_uIItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("Player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "Player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("QuickSlotsManager")] 
		public wCHandle<QuickSlotsManager> QuickSlotsManager
		{
			get
			{
				if (_quickSlotsManager == null)
				{
					_quickSlotsManager = (wCHandle<QuickSlotsManager>) CR2WTypeManager.Create("whandle:QuickSlotsManager", "QuickSlotsManager", cr2w, this);
				}
				return _quickSlotsManager;
			}
			set
			{
				if (_quickSlotsManager == value)
				{
					return;
				}
				_quickSlotsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("UiQuickItemsBlackboard")] 
		public CHandle<gameIBlackboard> UiQuickItemsBlackboard
		{
			get
			{
				if (_uiQuickItemsBlackboard == null)
				{
					_uiQuickItemsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "UiQuickItemsBlackboard", cr2w, this);
				}
				return _uiQuickItemsBlackboard;
			}
			set
			{
				if (_uiQuickItemsBlackboard == value)
				{
					return;
				}
				_uiQuickItemsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("KeyboardCommandBBID")] 
		public CUInt32 KeyboardCommandBBID
		{
			get
			{
				if (_keyboardCommandBBID == null)
				{
					_keyboardCommandBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "KeyboardCommandBBID", cr2w, this);
				}
				return _keyboardCommandBBID;
			}
			set
			{
				if (_keyboardCommandBBID == value)
				{
					return;
				}
				_keyboardCommandBBID = value;
				PropertySet(this);
			}
		}

		public keyboardHintGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
