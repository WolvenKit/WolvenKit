using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDebugUIGameController : gameuiBaseVehicleHUDGameController
	{
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private CUInt32 _vehicleBBStateConectionId;
		private CUInt32 _mountBBConnectionId;
		private CUInt32 _speedBBConnectionId;
		private CUInt32 _gearBBConnectionId;
		private CUInt32 _rpmValueBBConnectionId;
		private CUInt32 _rpmMaxBBConnectionId;
		private CUInt32 _radioStateBBConnectionId;
		private CUInt32 _radioNameBBConnectionId;
		private CBool _radioState;
		private CName _radioName;
		private wCHandle<inkTextWidget> _radioStateWidget;
		private wCHandle<inkTextWidget> _radioNameWidget;
		private CUInt32 _autopilotOnId;
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("mountBBConnectionId")] 
		public CUInt32 MountBBConnectionId
		{
			get
			{
				if (_mountBBConnectionId == null)
				{
					_mountBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "mountBBConnectionId", cr2w, this);
				}
				return _mountBBConnectionId;
			}
			set
			{
				if (_mountBBConnectionId == value)
				{
					return;
				}
				_mountBBConnectionId = value;
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
		[RED("radioStateBBConnectionId")] 
		public CUInt32 RadioStateBBConnectionId
		{
			get
			{
				if (_radioStateBBConnectionId == null)
				{
					_radioStateBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "radioStateBBConnectionId", cr2w, this);
				}
				return _radioStateBBConnectionId;
			}
			set
			{
				if (_radioStateBBConnectionId == value)
				{
					return;
				}
				_radioStateBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("radioNameBBConnectionId")] 
		public CUInt32 RadioNameBBConnectionId
		{
			get
			{
				if (_radioNameBBConnectionId == null)
				{
					_radioNameBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "radioNameBBConnectionId", cr2w, this);
				}
				return _radioNameBBConnectionId;
			}
			set
			{
				if (_radioNameBBConnectionId == value)
				{
					return;
				}
				_radioNameBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("radioState")] 
		public CBool RadioState
		{
			get
			{
				if (_radioState == null)
				{
					_radioState = (CBool) CR2WTypeManager.Create("Bool", "radioState", cr2w, this);
				}
				return _radioState;
			}
			set
			{
				if (_radioState == value)
				{
					return;
				}
				_radioState = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("radioName")] 
		public CName RadioName
		{
			get
			{
				if (_radioName == null)
				{
					_radioName = (CName) CR2WTypeManager.Create("CName", "radioName", cr2w, this);
				}
				return _radioName;
			}
			set
			{
				if (_radioName == value)
				{
					return;
				}
				_radioName = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("radioStateWidget")] 
		public wCHandle<inkTextWidget> RadioStateWidget
		{
			get
			{
				if (_radioStateWidget == null)
				{
					_radioStateWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "radioStateWidget", cr2w, this);
				}
				return _radioStateWidget;
			}
			set
			{
				if (_radioStateWidget == value)
				{
					return;
				}
				_radioStateWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("radioNameWidget")] 
		public wCHandle<inkTextWidget> RadioNameWidget
		{
			get
			{
				if (_radioNameWidget == null)
				{
					_radioNameWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "radioNameWidget", cr2w, this);
				}
				return _radioNameWidget;
			}
			set
			{
				if (_radioNameWidget == value)
				{
					return;
				}
				_radioNameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
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

		[Ordinal(24)] 
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

		[Ordinal(25)] 
		[RED("speedTextWidget")] 
		public wCHandle<inkTextWidget> SpeedTextWidget
		{
			get
			{
				if (_speedTextWidget == null)
				{
					_speedTextWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "speedTextWidget", cr2w, this);
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

		[Ordinal(26)] 
		[RED("gearTextWidget")] 
		public wCHandle<inkTextWidget> GearTextWidget
		{
			get
			{
				if (_gearTextWidget == null)
				{
					_gearTextWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "gearTextWidget", cr2w, this);
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

		[Ordinal(27)] 
		[RED("rpmValueWidget")] 
		public wCHandle<inkTextWidget> RpmValueWidget
		{
			get
			{
				if (_rpmValueWidget == null)
				{
					_rpmValueWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "rpmValueWidget", cr2w, this);
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

		[Ordinal(28)] 
		[RED("rpmGaugeForegroundWidget")] 
		public wCHandle<inkRectangleWidget> RpmGaugeForegroundWidget
		{
			get
			{
				if (_rpmGaugeForegroundWidget == null)
				{
					_rpmGaugeForegroundWidget = (wCHandle<inkRectangleWidget>) CR2WTypeManager.Create("whandle:inkRectangleWidget", "rpmGaugeForegroundWidget", cr2w, this);
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
		[RED("rpmMinValue")] 
		public CFloat RpmMinValue
		{
			get
			{
				if (_rpmMinValue == null)
				{
					_rpmMinValue = (CFloat) CR2WTypeManager.Create("Float", "rpmMinValue", cr2w, this);
				}
				return _rpmMinValue;
			}
			set
			{
				if (_rpmMinValue == value)
				{
					return;
				}
				_rpmMinValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
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

		[Ordinal(32)] 
		[RED("rpmMaxValueInitialized")] 
		public CBool RpmMaxValueInitialized
		{
			get
			{
				if (_rpmMaxValueInitialized == null)
				{
					_rpmMaxValueInitialized = (CBool) CR2WTypeManager.Create("Bool", "rpmMaxValueInitialized", cr2w, this);
				}
				return _rpmMaxValueInitialized;
			}
			set
			{
				if (_rpmMaxValueInitialized == value)
				{
					return;
				}
				_rpmMaxValueInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("autopilotTextWidget")] 
		public wCHandle<inkTextWidget> AutopilotTextWidget
		{
			get
			{
				if (_autopilotTextWidget == null)
				{
					_autopilotTextWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "autopilotTextWidget", cr2w, this);
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

		[Ordinal(34)] 
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

		[Ordinal(35)] 
		[RED("useDebugUI")] 
		public CBool UseDebugUI
		{
			get
			{
				if (_useDebugUI == null)
				{
					_useDebugUI = (CBool) CR2WTypeManager.Create("Bool", "useDebugUI", cr2w, this);
				}
				return _useDebugUI;
			}
			set
			{
				if (_useDebugUI == value)
				{
					return;
				}
				_useDebugUI = value;
				PropertySet(this);
			}
		}

		public vehicleDebugUIGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
