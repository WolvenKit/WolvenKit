using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class dialogWidgetGameController : InteractionUIBase
	{
		private wCHandle<inkCanvasWidget> _root;
		private inkBasePanelWidgetReference _hubsContainer;
		private CArray<wCHandle<DialogHubLogicController>> _hubControllers;
		private CHandle<DialogHubLogicController> _activeHubController;
		private gameinteractionsvisDialogChoiceHubs _data;
		private CInt32 _activeHubID;
		private CInt32 _prevActiveHubID;
		private CInt32 _selectedIndex;
		private CFloat _fadeAnimTime;
		private CFloat _fadeDelay;
		private CBool _dialogFocusInputHintShown;
		private CBool _hubAvailable;
		private CHandle<inkanimProxy> _animCloseHudProxy;
		private wCHandle<DialogHubLogicController> _currentFadeItem;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_SystemDef> _uiSystemBB;
		private CUInt32 _uiSystemId;

		[Ordinal(23)] 
		[RED("root")] 
		public wCHandle<inkCanvasWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("hubsContainer")] 
		public inkBasePanelWidgetReference HubsContainer
		{
			get
			{
				if (_hubsContainer == null)
				{
					_hubsContainer = (inkBasePanelWidgetReference) CR2WTypeManager.Create("inkBasePanelWidgetReference", "hubsContainer", cr2w, this);
				}
				return _hubsContainer;
			}
			set
			{
				if (_hubsContainer == value)
				{
					return;
				}
				_hubsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("hubControllers")] 
		public CArray<wCHandle<DialogHubLogicController>> HubControllers
		{
			get
			{
				if (_hubControllers == null)
				{
					_hubControllers = (CArray<wCHandle<DialogHubLogicController>>) CR2WTypeManager.Create("array:whandle:DialogHubLogicController", "hubControllers", cr2w, this);
				}
				return _hubControllers;
			}
			set
			{
				if (_hubControllers == value)
				{
					return;
				}
				_hubControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("activeHubController")] 
		public CHandle<DialogHubLogicController> ActiveHubController
		{
			get
			{
				if (_activeHubController == null)
				{
					_activeHubController = (CHandle<DialogHubLogicController>) CR2WTypeManager.Create("handle:DialogHubLogicController", "activeHubController", cr2w, this);
				}
				return _activeHubController;
			}
			set
			{
				if (_activeHubController == value)
				{
					return;
				}
				_activeHubController = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("data")] 
		public gameinteractionsvisDialogChoiceHubs Data
		{
			get
			{
				if (_data == null)
				{
					_data = (gameinteractionsvisDialogChoiceHubs) CR2WTypeManager.Create("gameinteractionsvisDialogChoiceHubs", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("activeHubID")] 
		public CInt32 ActiveHubID
		{
			get
			{
				if (_activeHubID == null)
				{
					_activeHubID = (CInt32) CR2WTypeManager.Create("Int32", "activeHubID", cr2w, this);
				}
				return _activeHubID;
			}
			set
			{
				if (_activeHubID == value)
				{
					return;
				}
				_activeHubID = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("prevActiveHubID")] 
		public CInt32 PrevActiveHubID
		{
			get
			{
				if (_prevActiveHubID == null)
				{
					_prevActiveHubID = (CInt32) CR2WTypeManager.Create("Int32", "prevActiveHubID", cr2w, this);
				}
				return _prevActiveHubID;
			}
			set
			{
				if (_prevActiveHubID == value)
				{
					return;
				}
				_prevActiveHubID = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("selectedIndex")] 
		public CInt32 SelectedIndex
		{
			get
			{
				if (_selectedIndex == null)
				{
					_selectedIndex = (CInt32) CR2WTypeManager.Create("Int32", "selectedIndex", cr2w, this);
				}
				return _selectedIndex;
			}
			set
			{
				if (_selectedIndex == value)
				{
					return;
				}
				_selectedIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("fadeAnimTime")] 
		public CFloat FadeAnimTime
		{
			get
			{
				if (_fadeAnimTime == null)
				{
					_fadeAnimTime = (CFloat) CR2WTypeManager.Create("Float", "fadeAnimTime", cr2w, this);
				}
				return _fadeAnimTime;
			}
			set
			{
				if (_fadeAnimTime == value)
				{
					return;
				}
				_fadeAnimTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("fadeDelay")] 
		public CFloat FadeDelay
		{
			get
			{
				if (_fadeDelay == null)
				{
					_fadeDelay = (CFloat) CR2WTypeManager.Create("Float", "fadeDelay", cr2w, this);
				}
				return _fadeDelay;
			}
			set
			{
				if (_fadeDelay == value)
				{
					return;
				}
				_fadeDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("dialogFocusInputHintShown")] 
		public CBool DialogFocusInputHintShown
		{
			get
			{
				if (_dialogFocusInputHintShown == null)
				{
					_dialogFocusInputHintShown = (CBool) CR2WTypeManager.Create("Bool", "dialogFocusInputHintShown", cr2w, this);
				}
				return _dialogFocusInputHintShown;
			}
			set
			{
				if (_dialogFocusInputHintShown == value)
				{
					return;
				}
				_dialogFocusInputHintShown = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("hubAvailable")] 
		public CBool HubAvailable
		{
			get
			{
				if (_hubAvailable == null)
				{
					_hubAvailable = (CBool) CR2WTypeManager.Create("Bool", "hubAvailable", cr2w, this);
				}
				return _hubAvailable;
			}
			set
			{
				if (_hubAvailable == value)
				{
					return;
				}
				_hubAvailable = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("animCloseHudProxy")] 
		public CHandle<inkanimProxy> AnimCloseHudProxy
		{
			get
			{
				if (_animCloseHudProxy == null)
				{
					_animCloseHudProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animCloseHudProxy", cr2w, this);
				}
				return _animCloseHudProxy;
			}
			set
			{
				if (_animCloseHudProxy == value)
				{
					return;
				}
				_animCloseHudProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("currentFadeItem")] 
		public wCHandle<DialogHubLogicController> CurrentFadeItem
		{
			get
			{
				if (_currentFadeItem == null)
				{
					_currentFadeItem = (wCHandle<DialogHubLogicController>) CR2WTypeManager.Create("whandle:DialogHubLogicController", "currentFadeItem", cr2w, this);
				}
				return _currentFadeItem;
			}
			set
			{
				if (_currentFadeItem == value)
				{
					return;
				}
				_currentFadeItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get
			{
				if (_uiSystemBB == null)
				{
					_uiSystemBB = (CHandle<UI_SystemDef>) CR2WTypeManager.Create("handle:UI_SystemDef", "uiSystemBB", cr2w, this);
				}
				return _uiSystemBB;
			}
			set
			{
				if (_uiSystemBB == value)
				{
					return;
				}
				_uiSystemBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("uiSystemId")] 
		public CUInt32 UiSystemId
		{
			get
			{
				if (_uiSystemId == null)
				{
					_uiSystemId = (CUInt32) CR2WTypeManager.Create("Uint32", "uiSystemId", cr2w, this);
				}
				return _uiSystemId;
			}
			set
			{
				if (_uiSystemId == value)
				{
					return;
				}
				_uiSystemId = value;
				PropertySet(this);
			}
		}

		public dialogWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
