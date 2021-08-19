using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorInkGameController : DeviceInkGameControllerBase
	{
		private inkVerticalPanelWidgetReference _verticalPanel;
		private inkTextWidgetReference _currentFloorTextWidget;
		private inkCanvasWidgetReference _openCloseButtonWidgets;
		private inkFlexWidgetReference _elevatorUpArrowsWidget;
		private inkFlexWidgetReference _elevatorDownArrowsWidget;
		private inkCanvasWidgetReference _waitingStateWidget;
		private inkCanvasWidgetReference _dataScanningWidget;
		private inkCanvasWidgetReference _elevatorStoppedWidget;
		private CBool _isPlayerScanned;
		private CBool _isPaused;
		private CBool _isAuthorized;
		private CHandle<inkanimProxy> _animProxy;
		private CArray<CFloat> _buttonSizes;
		private CHandle<redCallbackObject> _onChangeFloorListener;
		private CHandle<redCallbackObject> _onPlayerScannedListener;
		private CHandle<redCallbackObject> _onPausedChangeListener;

		[Ordinal(16)] 
		[RED("verticalPanel")] 
		public inkVerticalPanelWidgetReference VerticalPanel
		{
			get => GetProperty(ref _verticalPanel);
			set => SetProperty(ref _verticalPanel, value);
		}

		[Ordinal(17)] 
		[RED("currentFloorTextWidget")] 
		public inkTextWidgetReference CurrentFloorTextWidget
		{
			get => GetProperty(ref _currentFloorTextWidget);
			set => SetProperty(ref _currentFloorTextWidget, value);
		}

		[Ordinal(18)] 
		[RED("openCloseButtonWidgets")] 
		public inkCanvasWidgetReference OpenCloseButtonWidgets
		{
			get => GetProperty(ref _openCloseButtonWidgets);
			set => SetProperty(ref _openCloseButtonWidgets, value);
		}

		[Ordinal(19)] 
		[RED("elevatorUpArrowsWidget")] 
		public inkFlexWidgetReference ElevatorUpArrowsWidget
		{
			get => GetProperty(ref _elevatorUpArrowsWidget);
			set => SetProperty(ref _elevatorUpArrowsWidget, value);
		}

		[Ordinal(20)] 
		[RED("elevatorDownArrowsWidget")] 
		public inkFlexWidgetReference ElevatorDownArrowsWidget
		{
			get => GetProperty(ref _elevatorDownArrowsWidget);
			set => SetProperty(ref _elevatorDownArrowsWidget, value);
		}

		[Ordinal(21)] 
		[RED("waitingStateWidget")] 
		public inkCanvasWidgetReference WaitingStateWidget
		{
			get => GetProperty(ref _waitingStateWidget);
			set => SetProperty(ref _waitingStateWidget, value);
		}

		[Ordinal(22)] 
		[RED("dataScanningWidget")] 
		public inkCanvasWidgetReference DataScanningWidget
		{
			get => GetProperty(ref _dataScanningWidget);
			set => SetProperty(ref _dataScanningWidget, value);
		}

		[Ordinal(23)] 
		[RED("elevatorStoppedWidget")] 
		public inkCanvasWidgetReference ElevatorStoppedWidget
		{
			get => GetProperty(ref _elevatorStoppedWidget);
			set => SetProperty(ref _elevatorStoppedWidget, value);
		}

		[Ordinal(24)] 
		[RED("isPlayerScanned")] 
		public CBool IsPlayerScanned
		{
			get => GetProperty(ref _isPlayerScanned);
			set => SetProperty(ref _isPlayerScanned, value);
		}

		[Ordinal(25)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get => GetProperty(ref _isPaused);
			set => SetProperty(ref _isPaused, value);
		}

		[Ordinal(26)] 
		[RED("isAuthorized")] 
		public CBool IsAuthorized
		{
			get => GetProperty(ref _isAuthorized);
			set => SetProperty(ref _isAuthorized, value);
		}

		[Ordinal(27)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(28)] 
		[RED("buttonSizes")] 
		public CArray<CFloat> ButtonSizes
		{
			get => GetProperty(ref _buttonSizes);
			set => SetProperty(ref _buttonSizes, value);
		}

		[Ordinal(29)] 
		[RED("onChangeFloorListener")] 
		public CHandle<redCallbackObject> OnChangeFloorListener
		{
			get => GetProperty(ref _onChangeFloorListener);
			set => SetProperty(ref _onChangeFloorListener, value);
		}

		[Ordinal(30)] 
		[RED("onPlayerScannedListener")] 
		public CHandle<redCallbackObject> OnPlayerScannedListener
		{
			get => GetProperty(ref _onPlayerScannedListener);
			set => SetProperty(ref _onPlayerScannedListener, value);
		}

		[Ordinal(31)] 
		[RED("onPausedChangeListener")] 
		public CHandle<redCallbackObject> OnPausedChangeListener
		{
			get => GetProperty(ref _onPausedChangeListener);
			set => SetProperty(ref _onPausedChangeListener, value);
		}

		public ElevatorInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
