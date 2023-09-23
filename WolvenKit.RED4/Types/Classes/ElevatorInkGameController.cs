using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElevatorInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("verticalPanel")] 
		public inkVerticalPanelWidgetReference VerticalPanel
		{
			get => GetPropertyValue<inkVerticalPanelWidgetReference>();
			set => SetPropertyValue<inkVerticalPanelWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("currentFloorTextWidget")] 
		public inkTextWidgetReference CurrentFloorTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("openCloseButtonWidgets")] 
		public inkCanvasWidgetReference OpenCloseButtonWidgets
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("elevatorUpArrowsWidget")] 
		public inkFlexWidgetReference ElevatorUpArrowsWidget
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("elevatorDownArrowsWidget")] 
		public inkFlexWidgetReference ElevatorDownArrowsWidget
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("waitingStateWidget")] 
		public inkCanvasWidgetReference WaitingStateWidget
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("dataScanningWidget")] 
		public inkCanvasWidgetReference DataScanningWidget
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("elevatorStoppedWidget")] 
		public inkCanvasWidgetReference ElevatorStoppedWidget
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("isPlayerScanned")] 
		public CBool IsPlayerScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("isAuthorized")] 
		public CBool IsAuthorized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(28)] 
		[RED("buttonSizes")] 
		public CArray<CFloat> ButtonSizes
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(29)] 
		[RED("onChangeFloorListener")] 
		public CHandle<redCallbackObject> OnChangeFloorListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("onPlayerScannedListener")] 
		public CHandle<redCallbackObject> OnPlayerScannedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("onPausedChangeListener")] 
		public CHandle<redCallbackObject> OnPausedChangeListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public ElevatorInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
