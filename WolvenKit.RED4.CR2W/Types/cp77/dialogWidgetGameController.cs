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
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(24)] 
		[RED("hubsContainer")] 
		public inkBasePanelWidgetReference HubsContainer
		{
			get => GetProperty(ref _hubsContainer);
			set => SetProperty(ref _hubsContainer, value);
		}

		[Ordinal(25)] 
		[RED("hubControllers")] 
		public CArray<wCHandle<DialogHubLogicController>> HubControllers
		{
			get => GetProperty(ref _hubControllers);
			set => SetProperty(ref _hubControllers, value);
		}

		[Ordinal(26)] 
		[RED("activeHubController")] 
		public CHandle<DialogHubLogicController> ActiveHubController
		{
			get => GetProperty(ref _activeHubController);
			set => SetProperty(ref _activeHubController, value);
		}

		[Ordinal(27)] 
		[RED("data")] 
		public gameinteractionsvisDialogChoiceHubs Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(28)] 
		[RED("activeHubID")] 
		public CInt32 ActiveHubID
		{
			get => GetProperty(ref _activeHubID);
			set => SetProperty(ref _activeHubID, value);
		}

		[Ordinal(29)] 
		[RED("prevActiveHubID")] 
		public CInt32 PrevActiveHubID
		{
			get => GetProperty(ref _prevActiveHubID);
			set => SetProperty(ref _prevActiveHubID, value);
		}

		[Ordinal(30)] 
		[RED("selectedIndex")] 
		public CInt32 SelectedIndex
		{
			get => GetProperty(ref _selectedIndex);
			set => SetProperty(ref _selectedIndex, value);
		}

		[Ordinal(31)] 
		[RED("fadeAnimTime")] 
		public CFloat FadeAnimTime
		{
			get => GetProperty(ref _fadeAnimTime);
			set => SetProperty(ref _fadeAnimTime, value);
		}

		[Ordinal(32)] 
		[RED("fadeDelay")] 
		public CFloat FadeDelay
		{
			get => GetProperty(ref _fadeDelay);
			set => SetProperty(ref _fadeDelay, value);
		}

		[Ordinal(33)] 
		[RED("dialogFocusInputHintShown")] 
		public CBool DialogFocusInputHintShown
		{
			get => GetProperty(ref _dialogFocusInputHintShown);
			set => SetProperty(ref _dialogFocusInputHintShown, value);
		}

		[Ordinal(34)] 
		[RED("hubAvailable")] 
		public CBool HubAvailable
		{
			get => GetProperty(ref _hubAvailable);
			set => SetProperty(ref _hubAvailable, value);
		}

		[Ordinal(35)] 
		[RED("animCloseHudProxy")] 
		public CHandle<inkanimProxy> AnimCloseHudProxy
		{
			get => GetProperty(ref _animCloseHudProxy);
			set => SetProperty(ref _animCloseHudProxy, value);
		}

		[Ordinal(36)] 
		[RED("currentFadeItem")] 
		public wCHandle<DialogHubLogicController> CurrentFadeItem
		{
			get => GetProperty(ref _currentFadeItem);
			set => SetProperty(ref _currentFadeItem, value);
		}

		[Ordinal(37)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(38)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get => GetProperty(ref _uiSystemBB);
			set => SetProperty(ref _uiSystemBB, value);
		}

		[Ordinal(39)] 
		[RED("uiSystemId")] 
		public CUInt32 UiSystemId
		{
			get => GetProperty(ref _uiSystemId);
			set => SetProperty(ref _uiSystemId, value);
		}

		public dialogWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
