using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVcarGameController : gameuiWidgetGameController
	{
		private CHandle<gameIBlackboard> _activeVehicleBlackboard;
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private CUInt32 _mountBBConnectionId;
		private CUInt32 _speedBBConnectionId;
		private CUInt32 _rpmValueBBConnectionId;
		private CUInt32 _rpmMaxBBConnectionId;
		private CUInt32 _autopilotOnId;
		private CUInt32 _playerVehStateId;
		private CBool _isInAutoPilot;
		private CBool _isInCombat;
		private CBool _wasCombat;
		private wCHandle<inkCanvasWidget> _rootWidget;
		private wCHandle<inkCanvasWidget> _windowWidget;
		private wCHandle<inkTextWidget> _speedTextWidget;
		private wCHandle<inkImageWidget> _rpmGaugeFullWidget;
		private Vector2 _rpmGaugeMaxSize;
		private wCHandle<inkCanvasWidget> _interiorRootWidget;
		private wCHandle<inkCanvasWidget> _interiorRPMWidget;
		private wCHandle<inkCanvasWidget> _interiorFluff1Widget;
		private wCHandle<inkCanvasWidget> _interiorFluff2Widget;
		private wCHandle<inkCanvasWidget> _interiorFluff3Widget;
		private wCHandle<inkCanvasWidget> _interiorFluff4Widget;
		private wCHandle<inkCanvasWidget> _interiorFluff5Widget;
		private wCHandle<inkCanvasWidget> _interiorFluff1Anim1Widget;
		private wCHandle<inkCanvasWidget> _interiorFluff1Anim2Widget;
		private wCHandle<inkCanvasWidget> _interiorFluff2Anim1Widget;
		private wCHandle<inkCanvasWidget> _interiorFluff2Anim2Widget;
		private CInt32 _activeChunks;
		private CHandle<inkanimProxy> _animFadeOutProxy;
		private CHandle<inkanimDefinition> _anim_exterior_fadein;
		private CHandle<inkanimDefinition> _anim_exterior_fadeout;
		private CHandle<inkanimDefinition> _anim_interior_fadeout;
		private CHandle<inkanimDefinition> _anim_interior_rpm_fadein;
		private CHandle<inkanimDefinition> _anim_interior_fluff1_fadein;
		private CHandle<inkanimDefinition> _anim_interior_fluff2_fadein;
		private CHandle<inkanimDefinition> _anim_interior_fluff3_fadein;
		private CHandle<inkanimDefinition> _anim_interior_fluff4_fadein;
		private CHandle<inkanimDefinition> _anim_interior_fluff5_fadein;
		private CHandle<inkanimProxy> _animFluffFadeInProxy;
		private CHandle<inkanimDefinition> _anim_interior_fluff1_anim1;
		private CHandle<inkanimDefinition> _anim_interior_fluff1_anim2;
		private CHandle<inkanimDefinition> _anim_interior_fluff2_anim1;
		private CHandle<inkanimDefinition> _anim_interior_fluff2_anim2;
		private inkanimPlaybackOptions _fluff1animOptions1;
		private inkanimPlaybackOptions _fluff1animOptions2;
		private inkanimPlaybackOptions _fluff2animOptions1;
		private inkanimPlaybackOptions _fluff2animOptions2;
		private CBool _isWindow;
		private CBool _isInterior;
		private CBool _hasSpeed;
		private CBool _hasRPM;
		private CInt32 _chunksNumber;
		private CName _dynamicRpmPath;
		private CInt32 _rpmPerChunk;
		private CBool _hasRevMax;
		private CName _revMaxPath;
		private CInt32 _revMaxChunk;
		private CName _windowWidgetPath;
		private CName _interiorWidgetPath;
		private CName _interiorRPMWidgetPath;
		private CName _interiorFluff1WidgetPath;
		private CName _interiorFluff2WidgetPath;
		private CName _interiorFluff3WidgetPath;
		private CName _interiorFluff4WidgetPath;
		private CName _interiorFluff5WidgetPath;
		private CName _interiorFluff1Anim1WidgetPath;
		private CName _interiorFluff1Anim2WidgetPath;
		private CName _interiorFluff2Anim1WidgetPath;
		private CName _interiorFluff2Anim2WidgetPath;

		[Ordinal(2)] 
		[RED("activeVehicleBlackboard")] 
		public CHandle<gameIBlackboard> ActiveVehicleBlackboard
		{
			get
			{
				if (_activeVehicleBlackboard == null)
				{
					_activeVehicleBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "activeVehicleBlackboard", cr2w, this);
				}
				return _activeVehicleBlackboard;
			}
			set
			{
				if (_activeVehicleBlackboard == value)
				{
					return;
				}
				_activeVehicleBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("playerVehStateId")] 
		public CUInt32 PlayerVehStateId
		{
			get
			{
				if (_playerVehStateId == null)
				{
					_playerVehStateId = (CUInt32) CR2WTypeManager.Create("Uint32", "playerVehStateId", cr2w, this);
				}
				return _playerVehStateId;
			}
			set
			{
				if (_playerVehStateId == value)
				{
					return;
				}
				_playerVehStateId = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("isInCombat")] 
		public CBool IsInCombat
		{
			get
			{
				if (_isInCombat == null)
				{
					_isInCombat = (CBool) CR2WTypeManager.Create("Bool", "isInCombat", cr2w, this);
				}
				return _isInCombat;
			}
			set
			{
				if (_isInCombat == value)
				{
					return;
				}
				_isInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("wasCombat")] 
		public CBool WasCombat
		{
			get
			{
				if (_wasCombat == null)
				{
					_wasCombat = (CBool) CR2WTypeManager.Create("Bool", "wasCombat", cr2w, this);
				}
				return _wasCombat;
			}
			set
			{
				if (_wasCombat == value)
				{
					return;
				}
				_wasCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("windowWidget")] 
		public wCHandle<inkCanvasWidget> WindowWidget
		{
			get
			{
				if (_windowWidget == null)
				{
					_windowWidget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "windowWidget", cr2w, this);
				}
				return _windowWidget;
			}
			set
			{
				if (_windowWidget == value)
				{
					return;
				}
				_windowWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("rpmGaugeFullWidget")] 
		public wCHandle<inkImageWidget> RpmGaugeFullWidget
		{
			get
			{
				if (_rpmGaugeFullWidget == null)
				{
					_rpmGaugeFullWidget = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "rpmGaugeFullWidget", cr2w, this);
				}
				return _rpmGaugeFullWidget;
			}
			set
			{
				if (_rpmGaugeFullWidget == value)
				{
					return;
				}
				_rpmGaugeFullWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("interiorRootWidget")] 
		public wCHandle<inkCanvasWidget> InteriorRootWidget
		{
			get
			{
				if (_interiorRootWidget == null)
				{
					_interiorRootWidget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "interiorRootWidget", cr2w, this);
				}
				return _interiorRootWidget;
			}
			set
			{
				if (_interiorRootWidget == value)
				{
					return;
				}
				_interiorRootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("interiorRPMWidget")] 
		public wCHandle<inkCanvasWidget> InteriorRPMWidget
		{
			get
			{
				if (_interiorRPMWidget == null)
				{
					_interiorRPMWidget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "interiorRPMWidget", cr2w, this);
				}
				return _interiorRPMWidget;
			}
			set
			{
				if (_interiorRPMWidget == value)
				{
					return;
				}
				_interiorRPMWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("interiorFluff1Widget")] 
		public wCHandle<inkCanvasWidget> InteriorFluff1Widget
		{
			get
			{
				if (_interiorFluff1Widget == null)
				{
					_interiorFluff1Widget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "interiorFluff1Widget", cr2w, this);
				}
				return _interiorFluff1Widget;
			}
			set
			{
				if (_interiorFluff1Widget == value)
				{
					return;
				}
				_interiorFluff1Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("interiorFluff2Widget")] 
		public wCHandle<inkCanvasWidget> InteriorFluff2Widget
		{
			get
			{
				if (_interiorFluff2Widget == null)
				{
					_interiorFluff2Widget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "interiorFluff2Widget", cr2w, this);
				}
				return _interiorFluff2Widget;
			}
			set
			{
				if (_interiorFluff2Widget == value)
				{
					return;
				}
				_interiorFluff2Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("interiorFluff3Widget")] 
		public wCHandle<inkCanvasWidget> InteriorFluff3Widget
		{
			get
			{
				if (_interiorFluff3Widget == null)
				{
					_interiorFluff3Widget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "interiorFluff3Widget", cr2w, this);
				}
				return _interiorFluff3Widget;
			}
			set
			{
				if (_interiorFluff3Widget == value)
				{
					return;
				}
				_interiorFluff3Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("interiorFluff4Widget")] 
		public wCHandle<inkCanvasWidget> InteriorFluff4Widget
		{
			get
			{
				if (_interiorFluff4Widget == null)
				{
					_interiorFluff4Widget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "interiorFluff4Widget", cr2w, this);
				}
				return _interiorFluff4Widget;
			}
			set
			{
				if (_interiorFluff4Widget == value)
				{
					return;
				}
				_interiorFluff4Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("interiorFluff5Widget")] 
		public wCHandle<inkCanvasWidget> InteriorFluff5Widget
		{
			get
			{
				if (_interiorFluff5Widget == null)
				{
					_interiorFluff5Widget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "interiorFluff5Widget", cr2w, this);
				}
				return _interiorFluff5Widget;
			}
			set
			{
				if (_interiorFluff5Widget == value)
				{
					return;
				}
				_interiorFluff5Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("interiorFluff1Anim1Widget")] 
		public wCHandle<inkCanvasWidget> InteriorFluff1Anim1Widget
		{
			get
			{
				if (_interiorFluff1Anim1Widget == null)
				{
					_interiorFluff1Anim1Widget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "interiorFluff1Anim1Widget", cr2w, this);
				}
				return _interiorFluff1Anim1Widget;
			}
			set
			{
				if (_interiorFluff1Anim1Widget == value)
				{
					return;
				}
				_interiorFluff1Anim1Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("interiorFluff1Anim2Widget")] 
		public wCHandle<inkCanvasWidget> InteriorFluff1Anim2Widget
		{
			get
			{
				if (_interiorFluff1Anim2Widget == null)
				{
					_interiorFluff1Anim2Widget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "interiorFluff1Anim2Widget", cr2w, this);
				}
				return _interiorFluff1Anim2Widget;
			}
			set
			{
				if (_interiorFluff1Anim2Widget == value)
				{
					return;
				}
				_interiorFluff1Anim2Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("interiorFluff2Anim1Widget")] 
		public wCHandle<inkCanvasWidget> InteriorFluff2Anim1Widget
		{
			get
			{
				if (_interiorFluff2Anim1Widget == null)
				{
					_interiorFluff2Anim1Widget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "interiorFluff2Anim1Widget", cr2w, this);
				}
				return _interiorFluff2Anim1Widget;
			}
			set
			{
				if (_interiorFluff2Anim1Widget == value)
				{
					return;
				}
				_interiorFluff2Anim1Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("interiorFluff2Anim2Widget")] 
		public wCHandle<inkCanvasWidget> InteriorFluff2Anim2Widget
		{
			get
			{
				if (_interiorFluff2Anim2Widget == null)
				{
					_interiorFluff2Anim2Widget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "interiorFluff2Anim2Widget", cr2w, this);
				}
				return _interiorFluff2Anim2Widget;
			}
			set
			{
				if (_interiorFluff2Anim2Widget == value)
				{
					return;
				}
				_interiorFluff2Anim2Widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
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

		[Ordinal(30)] 
		[RED("animFadeOutProxy")] 
		public CHandle<inkanimProxy> AnimFadeOutProxy
		{
			get
			{
				if (_animFadeOutProxy == null)
				{
					_animFadeOutProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animFadeOutProxy", cr2w, this);
				}
				return _animFadeOutProxy;
			}
			set
			{
				if (_animFadeOutProxy == value)
				{
					return;
				}
				_animFadeOutProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("anim_exterior_fadein")] 
		public CHandle<inkanimDefinition> Anim_exterior_fadein
		{
			get
			{
				if (_anim_exterior_fadein == null)
				{
					_anim_exterior_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_exterior_fadein", cr2w, this);
				}
				return _anim_exterior_fadein;
			}
			set
			{
				if (_anim_exterior_fadein == value)
				{
					return;
				}
				_anim_exterior_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("anim_exterior_fadeout")] 
		public CHandle<inkanimDefinition> Anim_exterior_fadeout
		{
			get
			{
				if (_anim_exterior_fadeout == null)
				{
					_anim_exterior_fadeout = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_exterior_fadeout", cr2w, this);
				}
				return _anim_exterior_fadeout;
			}
			set
			{
				if (_anim_exterior_fadeout == value)
				{
					return;
				}
				_anim_exterior_fadeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("anim_interior_fadeout")] 
		public CHandle<inkanimDefinition> Anim_interior_fadeout
		{
			get
			{
				if (_anim_interior_fadeout == null)
				{
					_anim_interior_fadeout = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_interior_fadeout", cr2w, this);
				}
				return _anim_interior_fadeout;
			}
			set
			{
				if (_anim_interior_fadeout == value)
				{
					return;
				}
				_anim_interior_fadeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("anim_interior_rpm_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_rpm_fadein
		{
			get
			{
				if (_anim_interior_rpm_fadein == null)
				{
					_anim_interior_rpm_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_interior_rpm_fadein", cr2w, this);
				}
				return _anim_interior_rpm_fadein;
			}
			set
			{
				if (_anim_interior_rpm_fadein == value)
				{
					return;
				}
				_anim_interior_rpm_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("anim_interior_fluff1_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff1_fadein
		{
			get
			{
				if (_anim_interior_fluff1_fadein == null)
				{
					_anim_interior_fluff1_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_interior_fluff1_fadein", cr2w, this);
				}
				return _anim_interior_fluff1_fadein;
			}
			set
			{
				if (_anim_interior_fluff1_fadein == value)
				{
					return;
				}
				_anim_interior_fluff1_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("anim_interior_fluff2_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff2_fadein
		{
			get
			{
				if (_anim_interior_fluff2_fadein == null)
				{
					_anim_interior_fluff2_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_interior_fluff2_fadein", cr2w, this);
				}
				return _anim_interior_fluff2_fadein;
			}
			set
			{
				if (_anim_interior_fluff2_fadein == value)
				{
					return;
				}
				_anim_interior_fluff2_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("anim_interior_fluff3_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff3_fadein
		{
			get
			{
				if (_anim_interior_fluff3_fadein == null)
				{
					_anim_interior_fluff3_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_interior_fluff3_fadein", cr2w, this);
				}
				return _anim_interior_fluff3_fadein;
			}
			set
			{
				if (_anim_interior_fluff3_fadein == value)
				{
					return;
				}
				_anim_interior_fluff3_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("anim_interior_fluff4_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff4_fadein
		{
			get
			{
				if (_anim_interior_fluff4_fadein == null)
				{
					_anim_interior_fluff4_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_interior_fluff4_fadein", cr2w, this);
				}
				return _anim_interior_fluff4_fadein;
			}
			set
			{
				if (_anim_interior_fluff4_fadein == value)
				{
					return;
				}
				_anim_interior_fluff4_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("anim_interior_fluff5_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff5_fadein
		{
			get
			{
				if (_anim_interior_fluff5_fadein == null)
				{
					_anim_interior_fluff5_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_interior_fluff5_fadein", cr2w, this);
				}
				return _anim_interior_fluff5_fadein;
			}
			set
			{
				if (_anim_interior_fluff5_fadein == value)
				{
					return;
				}
				_anim_interior_fluff5_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("animFluffFadeInProxy")] 
		public CHandle<inkanimProxy> AnimFluffFadeInProxy
		{
			get
			{
				if (_animFluffFadeInProxy == null)
				{
					_animFluffFadeInProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animFluffFadeInProxy", cr2w, this);
				}
				return _animFluffFadeInProxy;
			}
			set
			{
				if (_animFluffFadeInProxy == value)
				{
					return;
				}
				_animFluffFadeInProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("anim_interior_fluff1_anim1")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff1_anim1
		{
			get
			{
				if (_anim_interior_fluff1_anim1 == null)
				{
					_anim_interior_fluff1_anim1 = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_interior_fluff1_anim1", cr2w, this);
				}
				return _anim_interior_fluff1_anim1;
			}
			set
			{
				if (_anim_interior_fluff1_anim1 == value)
				{
					return;
				}
				_anim_interior_fluff1_anim1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("anim_interior_fluff1_anim2")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff1_anim2
		{
			get
			{
				if (_anim_interior_fluff1_anim2 == null)
				{
					_anim_interior_fluff1_anim2 = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_interior_fluff1_anim2", cr2w, this);
				}
				return _anim_interior_fluff1_anim2;
			}
			set
			{
				if (_anim_interior_fluff1_anim2 == value)
				{
					return;
				}
				_anim_interior_fluff1_anim2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("anim_interior_fluff2_anim1")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff2_anim1
		{
			get
			{
				if (_anim_interior_fluff2_anim1 == null)
				{
					_anim_interior_fluff2_anim1 = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_interior_fluff2_anim1", cr2w, this);
				}
				return _anim_interior_fluff2_anim1;
			}
			set
			{
				if (_anim_interior_fluff2_anim1 == value)
				{
					return;
				}
				_anim_interior_fluff2_anim1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("anim_interior_fluff2_anim2")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff2_anim2
		{
			get
			{
				if (_anim_interior_fluff2_anim2 == null)
				{
					_anim_interior_fluff2_anim2 = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "anim_interior_fluff2_anim2", cr2w, this);
				}
				return _anim_interior_fluff2_anim2;
			}
			set
			{
				if (_anim_interior_fluff2_anim2 == value)
				{
					return;
				}
				_anim_interior_fluff2_anim2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("fluff1animOptions1")] 
		public inkanimPlaybackOptions Fluff1animOptions1
		{
			get
			{
				if (_fluff1animOptions1 == null)
				{
					_fluff1animOptions1 = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "fluff1animOptions1", cr2w, this);
				}
				return _fluff1animOptions1;
			}
			set
			{
				if (_fluff1animOptions1 == value)
				{
					return;
				}
				_fluff1animOptions1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("fluff1animOptions2")] 
		public inkanimPlaybackOptions Fluff1animOptions2
		{
			get
			{
				if (_fluff1animOptions2 == null)
				{
					_fluff1animOptions2 = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "fluff1animOptions2", cr2w, this);
				}
				return _fluff1animOptions2;
			}
			set
			{
				if (_fluff1animOptions2 == value)
				{
					return;
				}
				_fluff1animOptions2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("fluff2animOptions1")] 
		public inkanimPlaybackOptions Fluff2animOptions1
		{
			get
			{
				if (_fluff2animOptions1 == null)
				{
					_fluff2animOptions1 = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "fluff2animOptions1", cr2w, this);
				}
				return _fluff2animOptions1;
			}
			set
			{
				if (_fluff2animOptions1 == value)
				{
					return;
				}
				_fluff2animOptions1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("fluff2animOptions2")] 
		public inkanimPlaybackOptions Fluff2animOptions2
		{
			get
			{
				if (_fluff2animOptions2 == null)
				{
					_fluff2animOptions2 = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "fluff2animOptions2", cr2w, this);
				}
				return _fluff2animOptions2;
			}
			set
			{
				if (_fluff2animOptions2 == value)
				{
					return;
				}
				_fluff2animOptions2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("isWindow")] 
		public CBool IsWindow
		{
			get
			{
				if (_isWindow == null)
				{
					_isWindow = (CBool) CR2WTypeManager.Create("Bool", "isWindow", cr2w, this);
				}
				return _isWindow;
			}
			set
			{
				if (_isWindow == value)
				{
					return;
				}
				_isWindow = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("isInterior")] 
		public CBool IsInterior
		{
			get
			{
				if (_isInterior == null)
				{
					_isInterior = (CBool) CR2WTypeManager.Create("Bool", "isInterior", cr2w, this);
				}
				return _isInterior;
			}
			set
			{
				if (_isInterior == value)
				{
					return;
				}
				_isInterior = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("hasSpeed")] 
		public CBool HasSpeed
		{
			get
			{
				if (_hasSpeed == null)
				{
					_hasSpeed = (CBool) CR2WTypeManager.Create("Bool", "hasSpeed", cr2w, this);
				}
				return _hasSpeed;
			}
			set
			{
				if (_hasSpeed == value)
				{
					return;
				}
				_hasSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("hasRPM")] 
		public CBool HasRPM
		{
			get
			{
				if (_hasRPM == null)
				{
					_hasRPM = (CBool) CR2WTypeManager.Create("Bool", "hasRPM", cr2w, this);
				}
				return _hasRPM;
			}
			set
			{
				if (_hasRPM == value)
				{
					return;
				}
				_hasRPM = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
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

		[Ordinal(54)] 
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

		[Ordinal(55)] 
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

		[Ordinal(56)] 
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

		[Ordinal(57)] 
		[RED("revMaxPath")] 
		public CName RevMaxPath
		{
			get
			{
				if (_revMaxPath == null)
				{
					_revMaxPath = (CName) CR2WTypeManager.Create("CName", "revMaxPath", cr2w, this);
				}
				return _revMaxPath;
			}
			set
			{
				if (_revMaxPath == value)
				{
					return;
				}
				_revMaxPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("revMaxChunk")] 
		public CInt32 RevMaxChunk
		{
			get
			{
				if (_revMaxChunk == null)
				{
					_revMaxChunk = (CInt32) CR2WTypeManager.Create("Int32", "revMaxChunk", cr2w, this);
				}
				return _revMaxChunk;
			}
			set
			{
				if (_revMaxChunk == value)
				{
					return;
				}
				_revMaxChunk = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("windowWidgetPath")] 
		public CName WindowWidgetPath
		{
			get
			{
				if (_windowWidgetPath == null)
				{
					_windowWidgetPath = (CName) CR2WTypeManager.Create("CName", "windowWidgetPath", cr2w, this);
				}
				return _windowWidgetPath;
			}
			set
			{
				if (_windowWidgetPath == value)
				{
					return;
				}
				_windowWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("interiorWidgetPath")] 
		public CName InteriorWidgetPath
		{
			get
			{
				if (_interiorWidgetPath == null)
				{
					_interiorWidgetPath = (CName) CR2WTypeManager.Create("CName", "interiorWidgetPath", cr2w, this);
				}
				return _interiorWidgetPath;
			}
			set
			{
				if (_interiorWidgetPath == value)
				{
					return;
				}
				_interiorWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("interiorRPMWidgetPath")] 
		public CName InteriorRPMWidgetPath
		{
			get
			{
				if (_interiorRPMWidgetPath == null)
				{
					_interiorRPMWidgetPath = (CName) CR2WTypeManager.Create("CName", "interiorRPMWidgetPath", cr2w, this);
				}
				return _interiorRPMWidgetPath;
			}
			set
			{
				if (_interiorRPMWidgetPath == value)
				{
					return;
				}
				_interiorRPMWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("interiorFluff1WidgetPath")] 
		public CName InteriorFluff1WidgetPath
		{
			get
			{
				if (_interiorFluff1WidgetPath == null)
				{
					_interiorFluff1WidgetPath = (CName) CR2WTypeManager.Create("CName", "interiorFluff1WidgetPath", cr2w, this);
				}
				return _interiorFluff1WidgetPath;
			}
			set
			{
				if (_interiorFluff1WidgetPath == value)
				{
					return;
				}
				_interiorFluff1WidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("interiorFluff2WidgetPath")] 
		public CName InteriorFluff2WidgetPath
		{
			get
			{
				if (_interiorFluff2WidgetPath == null)
				{
					_interiorFluff2WidgetPath = (CName) CR2WTypeManager.Create("CName", "interiorFluff2WidgetPath", cr2w, this);
				}
				return _interiorFluff2WidgetPath;
			}
			set
			{
				if (_interiorFluff2WidgetPath == value)
				{
					return;
				}
				_interiorFluff2WidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("interiorFluff3WidgetPath")] 
		public CName InteriorFluff3WidgetPath
		{
			get
			{
				if (_interiorFluff3WidgetPath == null)
				{
					_interiorFluff3WidgetPath = (CName) CR2WTypeManager.Create("CName", "interiorFluff3WidgetPath", cr2w, this);
				}
				return _interiorFluff3WidgetPath;
			}
			set
			{
				if (_interiorFluff3WidgetPath == value)
				{
					return;
				}
				_interiorFluff3WidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("interiorFluff4WidgetPath")] 
		public CName InteriorFluff4WidgetPath
		{
			get
			{
				if (_interiorFluff4WidgetPath == null)
				{
					_interiorFluff4WidgetPath = (CName) CR2WTypeManager.Create("CName", "interiorFluff4WidgetPath", cr2w, this);
				}
				return _interiorFluff4WidgetPath;
			}
			set
			{
				if (_interiorFluff4WidgetPath == value)
				{
					return;
				}
				_interiorFluff4WidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("interiorFluff5WidgetPath")] 
		public CName InteriorFluff5WidgetPath
		{
			get
			{
				if (_interiorFluff5WidgetPath == null)
				{
					_interiorFluff5WidgetPath = (CName) CR2WTypeManager.Create("CName", "interiorFluff5WidgetPath", cr2w, this);
				}
				return _interiorFluff5WidgetPath;
			}
			set
			{
				if (_interiorFluff5WidgetPath == value)
				{
					return;
				}
				_interiorFluff5WidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("interiorFluff1Anim1WidgetPath")] 
		public CName InteriorFluff1Anim1WidgetPath
		{
			get
			{
				if (_interiorFluff1Anim1WidgetPath == null)
				{
					_interiorFluff1Anim1WidgetPath = (CName) CR2WTypeManager.Create("CName", "interiorFluff1Anim1WidgetPath", cr2w, this);
				}
				return _interiorFluff1Anim1WidgetPath;
			}
			set
			{
				if (_interiorFluff1Anim1WidgetPath == value)
				{
					return;
				}
				_interiorFluff1Anim1WidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("interiorFluff1Anim2WidgetPath")] 
		public CName InteriorFluff1Anim2WidgetPath
		{
			get
			{
				if (_interiorFluff1Anim2WidgetPath == null)
				{
					_interiorFluff1Anim2WidgetPath = (CName) CR2WTypeManager.Create("CName", "interiorFluff1Anim2WidgetPath", cr2w, this);
				}
				return _interiorFluff1Anim2WidgetPath;
			}
			set
			{
				if (_interiorFluff1Anim2WidgetPath == value)
				{
					return;
				}
				_interiorFluff1Anim2WidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("interiorFluff2Anim1WidgetPath")] 
		public CName InteriorFluff2Anim1WidgetPath
		{
			get
			{
				if (_interiorFluff2Anim1WidgetPath == null)
				{
					_interiorFluff2Anim1WidgetPath = (CName) CR2WTypeManager.Create("CName", "interiorFluff2Anim1WidgetPath", cr2w, this);
				}
				return _interiorFluff2Anim1WidgetPath;
			}
			set
			{
				if (_interiorFluff2Anim1WidgetPath == value)
				{
					return;
				}
				_interiorFluff2Anim1WidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("interiorFluff2Anim2WidgetPath")] 
		public CName InteriorFluff2Anim2WidgetPath
		{
			get
			{
				if (_interiorFluff2Anim2WidgetPath == null)
				{
					_interiorFluff2Anim2WidgetPath = (CName) CR2WTypeManager.Create("CName", "interiorFluff2Anim2WidgetPath", cr2w, this);
				}
				return _interiorFluff2Anim2WidgetPath;
			}
			set
			{
				if (_interiorFluff2Anim2WidgetPath == value)
				{
					return;
				}
				_interiorFluff2Anim2WidgetPath = value;
				PropertySet(this);
			}
		}

		public vehicleVcarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
