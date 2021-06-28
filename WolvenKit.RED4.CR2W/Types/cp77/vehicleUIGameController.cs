using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleUIGameController : gameuiHUDGameController
	{
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private wCHandle<vehicleBaseObject> _vehicle;
		private CHandle<VehicleComponentPS> _vehiclePS;
		private CUInt32 _vehicleBBStateConectionId;
		private CUInt32 _vehicleCollisionBBStateID;
		private CUInt32 _vehicleBBUIActivId;
		private wCHandle<inkWidget> _rootWidget;
		private CBool _uIEnabled;
		private CHandle<inkanimProxy> _startAnimProxy;
		private CHandle<inkanimProxy> _loopAnimProxy;
		private CHandle<inkanimProxy> _endAnimProxy;
		private CHandle<inkanimProxy> _loopingBootProxy;
		private inkWidgetReference _speedometerWidget;
		private inkWidgetReference _tachometerWidget;
		private inkWidgetReference _timeWidget;
		private inkWidgetReference _instruments;
		private inkWidgetReference _gearBox;
		private inkWidgetReference _radio;
		private inkWidgetReference _analogTachWidget;
		private inkWidgetReference _analogSpeedWidget;
		private CBool _isVehicleReady;

		[Ordinal(9)] 
		[RED("vehicleBlackboard")] 
		public wCHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetProperty(ref _vehicleBlackboard);
			set => SetProperty(ref _vehicleBlackboard, value);
		}

		[Ordinal(10)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(11)] 
		[RED("vehiclePS")] 
		public CHandle<VehicleComponentPS> VehiclePS
		{
			get => GetProperty(ref _vehiclePS);
			set => SetProperty(ref _vehiclePS, value);
		}

		[Ordinal(12)] 
		[RED("vehicleBBStateConectionId")] 
		public CUInt32 VehicleBBStateConectionId
		{
			get => GetProperty(ref _vehicleBBStateConectionId);
			set => SetProperty(ref _vehicleBBStateConectionId, value);
		}

		[Ordinal(13)] 
		[RED("vehicleCollisionBBStateID")] 
		public CUInt32 VehicleCollisionBBStateID
		{
			get => GetProperty(ref _vehicleCollisionBBStateID);
			set => SetProperty(ref _vehicleCollisionBBStateID, value);
		}

		[Ordinal(14)] 
		[RED("vehicleBBUIActivId")] 
		public CUInt32 VehicleBBUIActivId
		{
			get => GetProperty(ref _vehicleBBUIActivId);
			set => SetProperty(ref _vehicleBBUIActivId, value);
		}

		[Ordinal(15)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(16)] 
		[RED("UIEnabled")] 
		public CBool UIEnabled
		{
			get => GetProperty(ref _uIEnabled);
			set => SetProperty(ref _uIEnabled, value);
		}

		[Ordinal(17)] 
		[RED("startAnimProxy")] 
		public CHandle<inkanimProxy> StartAnimProxy
		{
			get => GetProperty(ref _startAnimProxy);
			set => SetProperty(ref _startAnimProxy, value);
		}

		[Ordinal(18)] 
		[RED("loopAnimProxy")] 
		public CHandle<inkanimProxy> LoopAnimProxy
		{
			get => GetProperty(ref _loopAnimProxy);
			set => SetProperty(ref _loopAnimProxy, value);
		}

		[Ordinal(19)] 
		[RED("endAnimProxy")] 
		public CHandle<inkanimProxy> EndAnimProxy
		{
			get => GetProperty(ref _endAnimProxy);
			set => SetProperty(ref _endAnimProxy, value);
		}

		[Ordinal(20)] 
		[RED("loopingBootProxy")] 
		public CHandle<inkanimProxy> LoopingBootProxy
		{
			get => GetProperty(ref _loopingBootProxy);
			set => SetProperty(ref _loopingBootProxy, value);
		}

		[Ordinal(21)] 
		[RED("speedometerWidget")] 
		public inkWidgetReference SpeedometerWidget
		{
			get => GetProperty(ref _speedometerWidget);
			set => SetProperty(ref _speedometerWidget, value);
		}

		[Ordinal(22)] 
		[RED("tachometerWidget")] 
		public inkWidgetReference TachometerWidget
		{
			get => GetProperty(ref _tachometerWidget);
			set => SetProperty(ref _tachometerWidget, value);
		}

		[Ordinal(23)] 
		[RED("timeWidget")] 
		public inkWidgetReference TimeWidget
		{
			get => GetProperty(ref _timeWidget);
			set => SetProperty(ref _timeWidget, value);
		}

		[Ordinal(24)] 
		[RED("instruments")] 
		public inkWidgetReference Instruments
		{
			get => GetProperty(ref _instruments);
			set => SetProperty(ref _instruments, value);
		}

		[Ordinal(25)] 
		[RED("gearBox")] 
		public inkWidgetReference GearBox
		{
			get => GetProperty(ref _gearBox);
			set => SetProperty(ref _gearBox, value);
		}

		[Ordinal(26)] 
		[RED("radio")] 
		public inkWidgetReference Radio
		{
			get => GetProperty(ref _radio);
			set => SetProperty(ref _radio, value);
		}

		[Ordinal(27)] 
		[RED("analogTachWidget")] 
		public inkWidgetReference AnalogTachWidget
		{
			get => GetProperty(ref _analogTachWidget);
			set => SetProperty(ref _analogTachWidget, value);
		}

		[Ordinal(28)] 
		[RED("analogSpeedWidget")] 
		public inkWidgetReference AnalogSpeedWidget
		{
			get => GetProperty(ref _analogSpeedWidget);
			set => SetProperty(ref _analogSpeedWidget, value);
		}

		[Ordinal(29)] 
		[RED("isVehicleReady")] 
		public CBool IsVehicleReady
		{
			get => GetProperty(ref _isVehicleReady);
			set => SetProperty(ref _isVehicleReady, value);
		}

		public vehicleUIGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
