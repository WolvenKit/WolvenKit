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
			get
			{
				if (_vehicleBlackboard == null)
				{
					_vehicleBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "vehicleBlackboard", cr2w, this);
				}
				return _vehicleBlackboard;
			}
			set
			{
				if (_vehicleBlackboard == value)
				{
					return;
				}
				_vehicleBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get
			{
				if (_vehicle == null)
				{
					_vehicle = (wCHandle<vehicleBaseObject>) CR2WTypeManager.Create("whandle:vehicleBaseObject", "vehicle", cr2w, this);
				}
				return _vehicle;
			}
			set
			{
				if (_vehicle == value)
				{
					return;
				}
				_vehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("vehiclePS")] 
		public CHandle<VehicleComponentPS> VehiclePS
		{
			get
			{
				if (_vehiclePS == null)
				{
					_vehiclePS = (CHandle<VehicleComponentPS>) CR2WTypeManager.Create("handle:VehicleComponentPS", "vehiclePS", cr2w, this);
				}
				return _vehiclePS;
			}
			set
			{
				if (_vehiclePS == value)
				{
					return;
				}
				_vehiclePS = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("vehicleBBStateConectionId")] 
		public CUInt32 VehicleBBStateConectionId
		{
			get
			{
				if (_vehicleBBStateConectionId == null)
				{
					_vehicleBBStateConectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleBBStateConectionId", cr2w, this);
				}
				return _vehicleBBStateConectionId;
			}
			set
			{
				if (_vehicleBBStateConectionId == value)
				{
					return;
				}
				_vehicleBBStateConectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("vehicleCollisionBBStateID")] 
		public CUInt32 VehicleCollisionBBStateID
		{
			get
			{
				if (_vehicleCollisionBBStateID == null)
				{
					_vehicleCollisionBBStateID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleCollisionBBStateID", cr2w, this);
				}
				return _vehicleCollisionBBStateID;
			}
			set
			{
				if (_vehicleCollisionBBStateID == value)
				{
					return;
				}
				_vehicleCollisionBBStateID = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("vehicleBBUIActivId")] 
		public CUInt32 VehicleBBUIActivId
		{
			get
			{
				if (_vehicleBBUIActivId == null)
				{
					_vehicleBBUIActivId = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleBBUIActivId", cr2w, this);
				}
				return _vehicleBBUIActivId;
			}
			set
			{
				if (_vehicleBBUIActivId == value)
				{
					return;
				}
				_vehicleBBUIActivId = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("UIEnabled")] 
		public CBool UIEnabled
		{
			get
			{
				if (_uIEnabled == null)
				{
					_uIEnabled = (CBool) CR2WTypeManager.Create("Bool", "UIEnabled", cr2w, this);
				}
				return _uIEnabled;
			}
			set
			{
				if (_uIEnabled == value)
				{
					return;
				}
				_uIEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("startAnimProxy")] 
		public CHandle<inkanimProxy> StartAnimProxy
		{
			get
			{
				if (_startAnimProxy == null)
				{
					_startAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "startAnimProxy", cr2w, this);
				}
				return _startAnimProxy;
			}
			set
			{
				if (_startAnimProxy == value)
				{
					return;
				}
				_startAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("loopAnimProxy")] 
		public CHandle<inkanimProxy> LoopAnimProxy
		{
			get
			{
				if (_loopAnimProxy == null)
				{
					_loopAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "loopAnimProxy", cr2w, this);
				}
				return _loopAnimProxy;
			}
			set
			{
				if (_loopAnimProxy == value)
				{
					return;
				}
				_loopAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("endAnimProxy")] 
		public CHandle<inkanimProxy> EndAnimProxy
		{
			get
			{
				if (_endAnimProxy == null)
				{
					_endAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "endAnimProxy", cr2w, this);
				}
				return _endAnimProxy;
			}
			set
			{
				if (_endAnimProxy == value)
				{
					return;
				}
				_endAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("loopingBootProxy")] 
		public CHandle<inkanimProxy> LoopingBootProxy
		{
			get
			{
				if (_loopingBootProxy == null)
				{
					_loopingBootProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "loopingBootProxy", cr2w, this);
				}
				return _loopingBootProxy;
			}
			set
			{
				if (_loopingBootProxy == value)
				{
					return;
				}
				_loopingBootProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("speedometerWidget")] 
		public inkWidgetReference SpeedometerWidget
		{
			get
			{
				if (_speedometerWidget == null)
				{
					_speedometerWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "speedometerWidget", cr2w, this);
				}
				return _speedometerWidget;
			}
			set
			{
				if (_speedometerWidget == value)
				{
					return;
				}
				_speedometerWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("tachometerWidget")] 
		public inkWidgetReference TachometerWidget
		{
			get
			{
				if (_tachometerWidget == null)
				{
					_tachometerWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tachometerWidget", cr2w, this);
				}
				return _tachometerWidget;
			}
			set
			{
				if (_tachometerWidget == value)
				{
					return;
				}
				_tachometerWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("timeWidget")] 
		public inkWidgetReference TimeWidget
		{
			get
			{
				if (_timeWidget == null)
				{
					_timeWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "timeWidget", cr2w, this);
				}
				return _timeWidget;
			}
			set
			{
				if (_timeWidget == value)
				{
					return;
				}
				_timeWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("instruments")] 
		public inkWidgetReference Instruments
		{
			get
			{
				if (_instruments == null)
				{
					_instruments = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "instruments", cr2w, this);
				}
				return _instruments;
			}
			set
			{
				if (_instruments == value)
				{
					return;
				}
				_instruments = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("gearBox")] 
		public inkWidgetReference GearBox
		{
			get
			{
				if (_gearBox == null)
				{
					_gearBox = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "gearBox", cr2w, this);
				}
				return _gearBox;
			}
			set
			{
				if (_gearBox == value)
				{
					return;
				}
				_gearBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("radio")] 
		public inkWidgetReference Radio
		{
			get
			{
				if (_radio == null)
				{
					_radio = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "radio", cr2w, this);
				}
				return _radio;
			}
			set
			{
				if (_radio == value)
				{
					return;
				}
				_radio = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("analogTachWidget")] 
		public inkWidgetReference AnalogTachWidget
		{
			get
			{
				if (_analogTachWidget == null)
				{
					_analogTachWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "analogTachWidget", cr2w, this);
				}
				return _analogTachWidget;
			}
			set
			{
				if (_analogTachWidget == value)
				{
					return;
				}
				_analogTachWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("analogSpeedWidget")] 
		public inkWidgetReference AnalogSpeedWidget
		{
			get
			{
				if (_analogSpeedWidget == null)
				{
					_analogSpeedWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "analogSpeedWidget", cr2w, this);
				}
				return _analogSpeedWidget;
			}
			set
			{
				if (_analogSpeedWidget == value)
				{
					return;
				}
				_analogSpeedWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("isVehicleReady")] 
		public CBool IsVehicleReady
		{
			get
			{
				if (_isVehicleReady == null)
				{
					_isVehicleReady = (CBool) CR2WTypeManager.Create("Bool", "isVehicleReady", cr2w, this);
				}
				return _isVehicleReady;
			}
			set
			{
				if (_isVehicleReady == value)
				{
					return;
				}
				_isVehicleReady = value;
				PropertySet(this);
			}
		}

		public vehicleUIGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
