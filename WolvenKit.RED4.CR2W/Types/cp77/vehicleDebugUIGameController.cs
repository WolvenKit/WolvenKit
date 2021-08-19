using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDebugUIGameController : gameuiBaseVehicleHUDGameController
	{
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private CHandle<redCallbackObject> _vehicleBBStateConectionId;
		private CHandle<redCallbackObject> _mountBBConnectionId;
		private CHandle<redCallbackObject> _speedBBConnectionId;
		private CHandle<redCallbackObject> _gearBBConnectionId;
		private CHandle<redCallbackObject> _rpmValueBBConnectionId;
		private CHandle<redCallbackObject> _rpmMaxBBConnectionId;
		private CHandle<redCallbackObject> _radioStateBBConnectionId;
		private CHandle<redCallbackObject> _radioNameBBConnectionId;
		private CBool _radioState;
		private CName _radioName;
		private wCHandle<inkTextWidget> _radioStateWidget;
		private wCHandle<inkTextWidget> _radioNameWidget;
		private CHandle<redCallbackObject> _autopilotOnId;
		private wCHandle<inkCanvasWidget> _rootWidget;
		private wCHandle<inkTextWidget> _speedTextWidget;
		private wCHandle<inkTextWidget> _gearTextWidget;
		private wCHandle<inkTextWidget> _rpmValueWidget;
		private wCHandle<inkRectangleWidget> _rpmGaugeForegroundWidget;
		private Vector2 _rpmGaugeMaxSize;
		private CFloat _rpmMinValue;
		private CFloat _rpmMaxValue;
		private CBool _rpmMaxValueInitialized;
		private wCHandle<inkTextWidget> _autopilotTextWidget;
		private CBool _isInAutoPilot;
		private CBool _useDebugUI;

		[Ordinal(10)] 
		[RED("vehicleBlackboard")] 
		public wCHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetProperty(ref _vehicleBlackboard);
			set => SetProperty(ref _vehicleBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("vehicleBBStateConectionId")] 
		public CHandle<redCallbackObject> VehicleBBStateConectionId
		{
			get => GetProperty(ref _vehicleBBStateConectionId);
			set => SetProperty(ref _vehicleBBStateConectionId, value);
		}

		[Ordinal(12)] 
		[RED("mountBBConnectionId")] 
		public CHandle<redCallbackObject> MountBBConnectionId
		{
			get => GetProperty(ref _mountBBConnectionId);
			set => SetProperty(ref _mountBBConnectionId, value);
		}

		[Ordinal(13)] 
		[RED("speedBBConnectionId")] 
		public CHandle<redCallbackObject> SpeedBBConnectionId
		{
			get => GetProperty(ref _speedBBConnectionId);
			set => SetProperty(ref _speedBBConnectionId, value);
		}

		[Ordinal(14)] 
		[RED("gearBBConnectionId")] 
		public CHandle<redCallbackObject> GearBBConnectionId
		{
			get => GetProperty(ref _gearBBConnectionId);
			set => SetProperty(ref _gearBBConnectionId, value);
		}

		[Ordinal(15)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetProperty(ref _rpmValueBBConnectionId);
			set => SetProperty(ref _rpmValueBBConnectionId, value);
		}

		[Ordinal(16)] 
		[RED("rpmMaxBBConnectionId")] 
		public CHandle<redCallbackObject> RpmMaxBBConnectionId
		{
			get => GetProperty(ref _rpmMaxBBConnectionId);
			set => SetProperty(ref _rpmMaxBBConnectionId, value);
		}

		[Ordinal(17)] 
		[RED("radioStateBBConnectionId")] 
		public CHandle<redCallbackObject> RadioStateBBConnectionId
		{
			get => GetProperty(ref _radioStateBBConnectionId);
			set => SetProperty(ref _radioStateBBConnectionId, value);
		}

		[Ordinal(18)] 
		[RED("radioNameBBConnectionId")] 
		public CHandle<redCallbackObject> RadioNameBBConnectionId
		{
			get => GetProperty(ref _radioNameBBConnectionId);
			set => SetProperty(ref _radioNameBBConnectionId, value);
		}

		[Ordinal(19)] 
		[RED("radioState")] 
		public CBool RadioState
		{
			get => GetProperty(ref _radioState);
			set => SetProperty(ref _radioState, value);
		}

		[Ordinal(20)] 
		[RED("radioName")] 
		public CName RadioName
		{
			get => GetProperty(ref _radioName);
			set => SetProperty(ref _radioName, value);
		}

		[Ordinal(21)] 
		[RED("radioStateWidget")] 
		public wCHandle<inkTextWidget> RadioStateWidget
		{
			get => GetProperty(ref _radioStateWidget);
			set => SetProperty(ref _radioStateWidget, value);
		}

		[Ordinal(22)] 
		[RED("radioNameWidget")] 
		public wCHandle<inkTextWidget> RadioNameWidget
		{
			get => GetProperty(ref _radioNameWidget);
			set => SetProperty(ref _radioNameWidget, value);
		}

		[Ordinal(23)] 
		[RED("autopilotOnId")] 
		public CHandle<redCallbackObject> AutopilotOnId
		{
			get => GetProperty(ref _autopilotOnId);
			set => SetProperty(ref _autopilotOnId, value);
		}

		[Ordinal(24)] 
		[RED("rootWidget")] 
		public wCHandle<inkCanvasWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(25)] 
		[RED("speedTextWidget")] 
		public wCHandle<inkTextWidget> SpeedTextWidget
		{
			get => GetProperty(ref _speedTextWidget);
			set => SetProperty(ref _speedTextWidget, value);
		}

		[Ordinal(26)] 
		[RED("gearTextWidget")] 
		public wCHandle<inkTextWidget> GearTextWidget
		{
			get => GetProperty(ref _gearTextWidget);
			set => SetProperty(ref _gearTextWidget, value);
		}

		[Ordinal(27)] 
		[RED("rpmValueWidget")] 
		public wCHandle<inkTextWidget> RpmValueWidget
		{
			get => GetProperty(ref _rpmValueWidget);
			set => SetProperty(ref _rpmValueWidget, value);
		}

		[Ordinal(28)] 
		[RED("rpmGaugeForegroundWidget")] 
		public wCHandle<inkRectangleWidget> RpmGaugeForegroundWidget
		{
			get => GetProperty(ref _rpmGaugeForegroundWidget);
			set => SetProperty(ref _rpmGaugeForegroundWidget, value);
		}

		[Ordinal(29)] 
		[RED("rpmGaugeMaxSize")] 
		public Vector2 RpmGaugeMaxSize
		{
			get => GetProperty(ref _rpmGaugeMaxSize);
			set => SetProperty(ref _rpmGaugeMaxSize, value);
		}

		[Ordinal(30)] 
		[RED("rpmMinValue")] 
		public CFloat RpmMinValue
		{
			get => GetProperty(ref _rpmMinValue);
			set => SetProperty(ref _rpmMinValue, value);
		}

		[Ordinal(31)] 
		[RED("rpmMaxValue")] 
		public CFloat RpmMaxValue
		{
			get => GetProperty(ref _rpmMaxValue);
			set => SetProperty(ref _rpmMaxValue, value);
		}

		[Ordinal(32)] 
		[RED("rpmMaxValueInitialized")] 
		public CBool RpmMaxValueInitialized
		{
			get => GetProperty(ref _rpmMaxValueInitialized);
			set => SetProperty(ref _rpmMaxValueInitialized, value);
		}

		[Ordinal(33)] 
		[RED("autopilotTextWidget")] 
		public wCHandle<inkTextWidget> AutopilotTextWidget
		{
			get => GetProperty(ref _autopilotTextWidget);
			set => SetProperty(ref _autopilotTextWidget, value);
		}

		[Ordinal(34)] 
		[RED("isInAutoPilot")] 
		public CBool IsInAutoPilot
		{
			get => GetProperty(ref _isInAutoPilot);
			set => SetProperty(ref _isInAutoPilot, value);
		}

		[Ordinal(35)] 
		[RED("useDebugUI")] 
		public CBool UseDebugUI
		{
			get => GetProperty(ref _useDebugUI);
			set => SetProperty(ref _useDebugUI, value);
		}

		public vehicleDebugUIGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
