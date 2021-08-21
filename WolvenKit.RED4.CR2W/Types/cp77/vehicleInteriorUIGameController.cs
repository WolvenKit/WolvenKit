using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleInteriorUIGameController : gameuiHUDGameController
	{
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private CHandle<redCallbackObject> _vehicleBBStateConectionId;
		private CHandle<redCallbackObject> _vehicleBBReadyConectionId;
		private CHandle<redCallbackObject> _vehicleBBUIActivId;
		private CHandle<redCallbackObject> _speedBBConnectionId;
		private CHandle<redCallbackObject> _gearBBConnectionId;
		private CHandle<redCallbackObject> _rpmValueBBConnectionId;
		private CHandle<redCallbackObject> _rpmMaxBBConnectionId;
		private CHandle<redCallbackObject> _autopilotOnId;
		private wCHandle<inkCanvasWidget> _rootWidget;
		private inkTextWidgetReference _speedTextWidget;
		private inkTextWidgetReference _gearTextWidget;
		private inkTextWidgetReference _rpmValueWidget;
		private inkRectangleWidgetReference _rpmGaugeForegroundWidget;
		private inkTextWidgetReference _autopilotTextWidget;
		private CInt32 _activeChunks;
		private CInt32 _chunksNumber;
		private CName _dynamicRpmPath;
		private CInt32 _rpmPerChunk;
		private CBool _hasRevMax;
		private Vector2 _rpmGaugeMaxSize;
		private CFloat _rpmMaxValue;
		private CBool _isInAutoPilot;
		private CBool _isVehicleReady;
		private CHandle<inkanimProxy> _hudRedLineAnimation;

		[Ordinal(9)] 
		[RED("vehicleBlackboard")] 
		public wCHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetProperty(ref _vehicleBlackboard);
			set => SetProperty(ref _vehicleBlackboard, value);
		}

		[Ordinal(10)] 
		[RED("vehicleBBStateConectionId")] 
		public CHandle<redCallbackObject> VehicleBBStateConectionId
		{
			get => GetProperty(ref _vehicleBBStateConectionId);
			set => SetProperty(ref _vehicleBBStateConectionId, value);
		}

		[Ordinal(11)] 
		[RED("vehicleBBReadyConectionId")] 
		public CHandle<redCallbackObject> VehicleBBReadyConectionId
		{
			get => GetProperty(ref _vehicleBBReadyConectionId);
			set => SetProperty(ref _vehicleBBReadyConectionId, value);
		}

		[Ordinal(12)] 
		[RED("vehicleBBUIActivId")] 
		public CHandle<redCallbackObject> VehicleBBUIActivId
		{
			get => GetProperty(ref _vehicleBBUIActivId);
			set => SetProperty(ref _vehicleBBUIActivId, value);
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
		[RED("autopilotOnId")] 
		public CHandle<redCallbackObject> AutopilotOnId
		{
			get => GetProperty(ref _autopilotOnId);
			set => SetProperty(ref _autopilotOnId, value);
		}

		[Ordinal(18)] 
		[RED("rootWidget")] 
		public wCHandle<inkCanvasWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(19)] 
		[RED("speedTextWidget")] 
		public inkTextWidgetReference SpeedTextWidget
		{
			get => GetProperty(ref _speedTextWidget);
			set => SetProperty(ref _speedTextWidget, value);
		}

		[Ordinal(20)] 
		[RED("gearTextWidget")] 
		public inkTextWidgetReference GearTextWidget
		{
			get => GetProperty(ref _gearTextWidget);
			set => SetProperty(ref _gearTextWidget, value);
		}

		[Ordinal(21)] 
		[RED("rpmValueWidget")] 
		public inkTextWidgetReference RpmValueWidget
		{
			get => GetProperty(ref _rpmValueWidget);
			set => SetProperty(ref _rpmValueWidget, value);
		}

		[Ordinal(22)] 
		[RED("rpmGaugeForegroundWidget")] 
		public inkRectangleWidgetReference RpmGaugeForegroundWidget
		{
			get => GetProperty(ref _rpmGaugeForegroundWidget);
			set => SetProperty(ref _rpmGaugeForegroundWidget, value);
		}

		[Ordinal(23)] 
		[RED("autopilotTextWidget")] 
		public inkTextWidgetReference AutopilotTextWidget
		{
			get => GetProperty(ref _autopilotTextWidget);
			set => SetProperty(ref _autopilotTextWidget, value);
		}

		[Ordinal(24)] 
		[RED("activeChunks")] 
		public CInt32 ActiveChunks
		{
			get => GetProperty(ref _activeChunks);
			set => SetProperty(ref _activeChunks, value);
		}

		[Ordinal(25)] 
		[RED("chunksNumber")] 
		public CInt32 ChunksNumber
		{
			get => GetProperty(ref _chunksNumber);
			set => SetProperty(ref _chunksNumber, value);
		}

		[Ordinal(26)] 
		[RED("dynamicRpmPath")] 
		public CName DynamicRpmPath
		{
			get => GetProperty(ref _dynamicRpmPath);
			set => SetProperty(ref _dynamicRpmPath, value);
		}

		[Ordinal(27)] 
		[RED("rpmPerChunk")] 
		public CInt32 RpmPerChunk
		{
			get => GetProperty(ref _rpmPerChunk);
			set => SetProperty(ref _rpmPerChunk, value);
		}

		[Ordinal(28)] 
		[RED("hasRevMax")] 
		public CBool HasRevMax
		{
			get => GetProperty(ref _hasRevMax);
			set => SetProperty(ref _hasRevMax, value);
		}

		[Ordinal(29)] 
		[RED("rpmGaugeMaxSize")] 
		public Vector2 RpmGaugeMaxSize
		{
			get => GetProperty(ref _rpmGaugeMaxSize);
			set => SetProperty(ref _rpmGaugeMaxSize, value);
		}

		[Ordinal(30)] 
		[RED("rpmMaxValue")] 
		public CFloat RpmMaxValue
		{
			get => GetProperty(ref _rpmMaxValue);
			set => SetProperty(ref _rpmMaxValue, value);
		}

		[Ordinal(31)] 
		[RED("isInAutoPilot")] 
		public CBool IsInAutoPilot
		{
			get => GetProperty(ref _isInAutoPilot);
			set => SetProperty(ref _isInAutoPilot, value);
		}

		[Ordinal(32)] 
		[RED("isVehicleReady")] 
		public CBool IsVehicleReady
		{
			get => GetProperty(ref _isVehicleReady);
			set => SetProperty(ref _isVehicleReady, value);
		}

		[Ordinal(33)] 
		[RED("HudRedLineAnimation")] 
		public CHandle<inkanimProxy> HudRedLineAnimation
		{
			get => GetProperty(ref _hudRedLineAnimation);
			set => SetProperty(ref _hudRedLineAnimation, value);
		}

		public vehicleInteriorUIGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
