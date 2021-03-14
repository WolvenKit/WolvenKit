using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleInteriorUIGameController : gameuiHUDGameController
	{
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private CUInt32 _vehicleBBStateConectionId;
		private CUInt32 _vehicleBBReadyConectionId;
		private CUInt32 _vehicleBBUIActivId;
		private CUInt32 _speedBBConnectionId;
		private CUInt32 _gearBBConnectionId;
		private CUInt32 _rpmValueBBConnectionId;
		private CUInt32 _rpmMaxBBConnectionId;
		private CUInt32 _autopilotOnId;
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

		[Ordinal(11)] 
		[RED("vehicleBBReadyConectionId")] 
		public CUInt32 VehicleBBReadyConectionId
		{
			get
			{
				if (_vehicleBBReadyConectionId == null)
				{
					_vehicleBBReadyConectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleBBReadyConectionId", cr2w, this);
				}
				return _vehicleBBReadyConectionId;
			}
			set
			{
				if (_vehicleBBReadyConectionId == value)
				{
					return;
				}
				_vehicleBBReadyConectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("speedBBConnectionId")] 
		public CUInt32 SpeedBBConnectionId
		{
			get
			{
				if (_speedBBConnectionId == null)
				{
					_speedBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "speedBBConnectionId", cr2w, this);
				}
				return _speedBBConnectionId;
			}
			set
			{
				if (_speedBBConnectionId == value)
				{
					return;
				}
				_speedBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("gearBBConnectionId")] 
		public CUInt32 GearBBConnectionId
		{
			get
			{
				if (_gearBBConnectionId == null)
				{
					_gearBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "gearBBConnectionId", cr2w, this);
				}
				return _gearBBConnectionId;
			}
			set
			{
				if (_gearBBConnectionId == value)
				{
					return;
				}
				_gearBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("rpmValueBBConnectionId")] 
		public CUInt32 RpmValueBBConnectionId
		{
			get
			{
				if (_rpmValueBBConnectionId == null)
				{
					_rpmValueBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "rpmValueBBConnectionId", cr2w, this);
				}
				return _rpmValueBBConnectionId;
			}
			set
			{
				if (_rpmValueBBConnectionId == value)
				{
					return;
				}
				_rpmValueBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("rpmMaxBBConnectionId")] 
		public CUInt32 RpmMaxBBConnectionId
		{
			get
			{
				if (_rpmMaxBBConnectionId == null)
				{
					_rpmMaxBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "rpmMaxBBConnectionId", cr2w, this);
				}
				return _rpmMaxBBConnectionId;
			}
			set
			{
				if (_rpmMaxBBConnectionId == value)
				{
					return;
				}
				_rpmMaxBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("autopilotOnId")] 
		public CUInt32 AutopilotOnId
		{
			get
			{
				if (_autopilotOnId == null)
				{
					_autopilotOnId = (CUInt32) CR2WTypeManager.Create("Uint32", "autopilotOnId", cr2w, this);
				}
				return _autopilotOnId;
			}
			set
			{
				if (_autopilotOnId == value)
				{
					return;
				}
				_autopilotOnId = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("rootWidget")] 
		public wCHandle<inkCanvasWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "rootWidget", cr2w, this);
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

		[Ordinal(19)] 
		[RED("speedTextWidget")] 
		public inkTextWidgetReference SpeedTextWidget
		{
			get
			{
				if (_speedTextWidget == null)
				{
					_speedTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "speedTextWidget", cr2w, this);
				}
				return _speedTextWidget;
			}
			set
			{
				if (_speedTextWidget == value)
				{
					return;
				}
				_speedTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("gearTextWidget")] 
		public inkTextWidgetReference GearTextWidget
		{
			get
			{
				if (_gearTextWidget == null)
				{
					_gearTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "gearTextWidget", cr2w, this);
				}
				return _gearTextWidget;
			}
			set
			{
				if (_gearTextWidget == value)
				{
					return;
				}
				_gearTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("rpmValueWidget")] 
		public inkTextWidgetReference RpmValueWidget
		{
			get
			{
				if (_rpmValueWidget == null)
				{
					_rpmValueWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "rpmValueWidget", cr2w, this);
				}
				return _rpmValueWidget;
			}
			set
			{
				if (_rpmValueWidget == value)
				{
					return;
				}
				_rpmValueWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("rpmGaugeForegroundWidget")] 
		public inkRectangleWidgetReference RpmGaugeForegroundWidget
		{
			get
			{
				if (_rpmGaugeForegroundWidget == null)
				{
					_rpmGaugeForegroundWidget = (inkRectangleWidgetReference) CR2WTypeManager.Create("inkRectangleWidgetReference", "rpmGaugeForegroundWidget", cr2w, this);
				}
				return _rpmGaugeForegroundWidget;
			}
			set
			{
				if (_rpmGaugeForegroundWidget == value)
				{
					return;
				}
				_rpmGaugeForegroundWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("autopilotTextWidget")] 
		public inkTextWidgetReference AutopilotTextWidget
		{
			get
			{
				if (_autopilotTextWidget == null)
				{
					_autopilotTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "autopilotTextWidget", cr2w, this);
				}
				return _autopilotTextWidget;
			}
			set
			{
				if (_autopilotTextWidget == value)
				{
					return;
				}
				_autopilotTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("activeChunks")] 
		public CInt32 ActiveChunks
		{
			get
			{
				if (_activeChunks == null)
				{
					_activeChunks = (CInt32) CR2WTypeManager.Create("Int32", "activeChunks", cr2w, this);
				}
				return _activeChunks;
			}
			set
			{
				if (_activeChunks == value)
				{
					return;
				}
				_activeChunks = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("chunksNumber")] 
		public CInt32 ChunksNumber
		{
			get
			{
				if (_chunksNumber == null)
				{
					_chunksNumber = (CInt32) CR2WTypeManager.Create("Int32", "chunksNumber", cr2w, this);
				}
				return _chunksNumber;
			}
			set
			{
				if (_chunksNumber == value)
				{
					return;
				}
				_chunksNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("dynamicRpmPath")] 
		public CName DynamicRpmPath
		{
			get
			{
				if (_dynamicRpmPath == null)
				{
					_dynamicRpmPath = (CName) CR2WTypeManager.Create("CName", "dynamicRpmPath", cr2w, this);
				}
				return _dynamicRpmPath;
			}
			set
			{
				if (_dynamicRpmPath == value)
				{
					return;
				}
				_dynamicRpmPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("rpmPerChunk")] 
		public CInt32 RpmPerChunk
		{
			get
			{
				if (_rpmPerChunk == null)
				{
					_rpmPerChunk = (CInt32) CR2WTypeManager.Create("Int32", "rpmPerChunk", cr2w, this);
				}
				return _rpmPerChunk;
			}
			set
			{
				if (_rpmPerChunk == value)
				{
					return;
				}
				_rpmPerChunk = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("hasRevMax")] 
		public CBool HasRevMax
		{
			get
			{
				if (_hasRevMax == null)
				{
					_hasRevMax = (CBool) CR2WTypeManager.Create("Bool", "hasRevMax", cr2w, this);
				}
				return _hasRevMax;
			}
			set
			{
				if (_hasRevMax == value)
				{
					return;
				}
				_hasRevMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("rpmGaugeMaxSize")] 
		public Vector2 RpmGaugeMaxSize
		{
			get
			{
				if (_rpmGaugeMaxSize == null)
				{
					_rpmGaugeMaxSize = (Vector2) CR2WTypeManager.Create("Vector2", "rpmGaugeMaxSize", cr2w, this);
				}
				return _rpmGaugeMaxSize;
			}
			set
			{
				if (_rpmGaugeMaxSize == value)
				{
					return;
				}
				_rpmGaugeMaxSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("rpmMaxValue")] 
		public CFloat RpmMaxValue
		{
			get
			{
				if (_rpmMaxValue == null)
				{
					_rpmMaxValue = (CFloat) CR2WTypeManager.Create("Float", "rpmMaxValue", cr2w, this);
				}
				return _rpmMaxValue;
			}
			set
			{
				if (_rpmMaxValue == value)
				{
					return;
				}
				_rpmMaxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("isInAutoPilot")] 
		public CBool IsInAutoPilot
		{
			get
			{
				if (_isInAutoPilot == null)
				{
					_isInAutoPilot = (CBool) CR2WTypeManager.Create("Bool", "isInAutoPilot", cr2w, this);
				}
				return _isInAutoPilot;
			}
			set
			{
				if (_isInAutoPilot == value)
				{
					return;
				}
				_isInAutoPilot = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
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

		[Ordinal(33)] 
		[RED("HudRedLineAnimation")] 
		public CHandle<inkanimProxy> HudRedLineAnimation
		{
			get
			{
				if (_hudRedLineAnimation == null)
				{
					_hudRedLineAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "HudRedLineAnimation", cr2w, this);
				}
				return _hudRedLineAnimation;
			}
			set
			{
				if (_hudRedLineAnimation == value)
				{
					return;
				}
				_hudRedLineAnimation = value;
				PropertySet(this);
			}
		}

		public vehicleInteriorUIGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
