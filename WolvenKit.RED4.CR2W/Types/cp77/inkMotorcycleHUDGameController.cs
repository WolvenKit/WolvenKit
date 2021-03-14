using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMotorcycleHUDGameController : gameuiBaseVehicleHUDGameController
	{
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private wCHandle<gameIBlackboard> _activeVehicleUIBlackboard;
		private CUInt32 _vehicleBBStateConectionId;
		private CUInt32 _speedBBConnectionId;
		private CUInt32 _gearBBConnectionId;
		private CUInt32 _tppBBConnectionId;
		private CUInt32 _rpmValueBBConnectionId;
		private CUInt32 _leanAngleBBConnectionId;
		private CUInt32 _playerStateBBConnectionId;
		private inkanimPlaybackOptions _playOptionReverse;
		private wCHandle<inkCanvasWidget> _rootWidget;
		private wCHandle<inkCanvasWidget> _mainCanvas;
		private CInt32 _activeChunks;
		private CInt32 _chunksNumber;
		private CName _dynamicRpmPath;
		private CInt32 _rpmPerChunk;
		private CBool _hasRevMax;
		private CBool _hiResMode;
		private CName _revMaxPath;
		private CInt32 _revMaxChunk;
		private CInt32 _revMax;
		private CInt32 _revRedLine;
		private CInt32 _maxSpeed;
		private inkTextWidgetReference _speedTextWidget;
		private inkTextWidgetReference _gearTextWidget;
		private inkTextWidgetReference _rPMTextWidget;
		private wCHandle<inkCanvasWidget> _lower;
		private wCHandle<inkCanvasWidget> _lowerSpeedBigR;
		private wCHandle<inkCanvasWidget> _lowerSpeedBigL;
		private wCHandle<inkCanvasWidget> _lowerSpeedSmallR;
		private wCHandle<inkCanvasWidget> _lowerSpeedSmallL;
		private wCHandle<inkImageWidget> _lowerSpeedFluffR;
		private wCHandle<inkImageWidget> _lowerSpeedFluffL;
		private wCHandle<inkCanvasWidget> _hudLowerPart;
		private wCHandle<inkCanvasWidget> _lowerfluff_R;
		private wCHandle<inkCanvasWidget> _lowerfluff_L;
		private CHandle<inkanimProxy> _hudHideAnimation;
		private CHandle<inkanimProxy> _hudShowAnimation;
		private CHandle<inkanimProxy> _hudRedLineAnimation;
		private CHandle<inkanimController> _fluffBlinking;

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
		[RED("activeVehicleUIBlackboard")] 
		public wCHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get
			{
				if (_activeVehicleUIBlackboard == null)
				{
					_activeVehicleUIBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "activeVehicleUIBlackboard", cr2w, this);
				}
				return _activeVehicleUIBlackboard;
			}
			set
			{
				if (_activeVehicleUIBlackboard == value)
				{
					return;
				}
				_activeVehicleUIBlackboard = value;
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
		[RED("tppBBConnectionId")] 
		public CUInt32 TppBBConnectionId
		{
			get
			{
				if (_tppBBConnectionId == null)
				{
					_tppBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "tppBBConnectionId", cr2w, this);
				}
				return _tppBBConnectionId;
			}
			set
			{
				if (_tppBBConnectionId == value)
				{
					return;
				}
				_tppBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
		[RED("leanAngleBBConnectionId")] 
		public CUInt32 LeanAngleBBConnectionId
		{
			get
			{
				if (_leanAngleBBConnectionId == null)
				{
					_leanAngleBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "leanAngleBBConnectionId", cr2w, this);
				}
				return _leanAngleBBConnectionId;
			}
			set
			{
				if (_leanAngleBBConnectionId == value)
				{
					return;
				}
				_leanAngleBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("playerStateBBConnectionId")] 
		public CUInt32 PlayerStateBBConnectionId
		{
			get
			{
				if (_playerStateBBConnectionId == null)
				{
					_playerStateBBConnectionId = (CUInt32) CR2WTypeManager.Create("Uint32", "playerStateBBConnectionId", cr2w, this);
				}
				return _playerStateBBConnectionId;
			}
			set
			{
				if (_playerStateBBConnectionId == value)
				{
					return;
				}
				_playerStateBBConnectionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("playOptionReverse")] 
		public inkanimPlaybackOptions PlayOptionReverse
		{
			get
			{
				if (_playOptionReverse == null)
				{
					_playOptionReverse = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "playOptionReverse", cr2w, this);
				}
				return _playOptionReverse;
			}
			set
			{
				if (_playOptionReverse == value)
				{
					return;
				}
				_playOptionReverse = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
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

		[Ordinal(21)] 
		[RED("mainCanvas")] 
		public wCHandle<inkCanvasWidget> MainCanvas
		{
			get
			{
				if (_mainCanvas == null)
				{
					_mainCanvas = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "mainCanvas", cr2w, this);
				}
				return _mainCanvas;
			}
			set
			{
				if (_mainCanvas == value)
				{
					return;
				}
				_mainCanvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
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

		[Ordinal(23)] 
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

		[Ordinal(24)] 
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

		[Ordinal(25)] 
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

		[Ordinal(26)] 
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

		[Ordinal(27)] 
		[RED("HiResMode")] 
		public CBool HiResMode
		{
			get
			{
				if (_hiResMode == null)
				{
					_hiResMode = (CBool) CR2WTypeManager.Create("Bool", "HiResMode", cr2w, this);
				}
				return _hiResMode;
			}
			set
			{
				if (_hiResMode == value)
				{
					return;
				}
				_hiResMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
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

		[Ordinal(29)] 
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

		[Ordinal(30)] 
		[RED("revMax")] 
		public CInt32 RevMax
		{
			get
			{
				if (_revMax == null)
				{
					_revMax = (CInt32) CR2WTypeManager.Create("Int32", "revMax", cr2w, this);
				}
				return _revMax;
			}
			set
			{
				if (_revMax == value)
				{
					return;
				}
				_revMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("revRedLine")] 
		public CInt32 RevRedLine
		{
			get
			{
				if (_revRedLine == null)
				{
					_revRedLine = (CInt32) CR2WTypeManager.Create("Int32", "revRedLine", cr2w, this);
				}
				return _revRedLine;
			}
			set
			{
				if (_revRedLine == value)
				{
					return;
				}
				_revRedLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("maxSpeed")] 
		public CInt32 MaxSpeed
		{
			get
			{
				if (_maxSpeed == null)
				{
					_maxSpeed = (CInt32) CR2WTypeManager.Create("Int32", "maxSpeed", cr2w, this);
				}
				return _maxSpeed;
			}
			set
			{
				if (_maxSpeed == value)
				{
					return;
				}
				_maxSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
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

		[Ordinal(34)] 
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

		[Ordinal(35)] 
		[RED("RPMTextWidget")] 
		public inkTextWidgetReference RPMTextWidget
		{
			get
			{
				if (_rPMTextWidget == null)
				{
					_rPMTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "RPMTextWidget", cr2w, this);
				}
				return _rPMTextWidget;
			}
			set
			{
				if (_rPMTextWidget == value)
				{
					return;
				}
				_rPMTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("lower")] 
		public wCHandle<inkCanvasWidget> Lower
		{
			get
			{
				if (_lower == null)
				{
					_lower = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "lower", cr2w, this);
				}
				return _lower;
			}
			set
			{
				if (_lower == value)
				{
					return;
				}
				_lower = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("lowerSpeedBigR")] 
		public wCHandle<inkCanvasWidget> LowerSpeedBigR
		{
			get
			{
				if (_lowerSpeedBigR == null)
				{
					_lowerSpeedBigR = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "lowerSpeedBigR", cr2w, this);
				}
				return _lowerSpeedBigR;
			}
			set
			{
				if (_lowerSpeedBigR == value)
				{
					return;
				}
				_lowerSpeedBigR = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("lowerSpeedBigL")] 
		public wCHandle<inkCanvasWidget> LowerSpeedBigL
		{
			get
			{
				if (_lowerSpeedBigL == null)
				{
					_lowerSpeedBigL = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "lowerSpeedBigL", cr2w, this);
				}
				return _lowerSpeedBigL;
			}
			set
			{
				if (_lowerSpeedBigL == value)
				{
					return;
				}
				_lowerSpeedBigL = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("lowerSpeedSmallR")] 
		public wCHandle<inkCanvasWidget> LowerSpeedSmallR
		{
			get
			{
				if (_lowerSpeedSmallR == null)
				{
					_lowerSpeedSmallR = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "lowerSpeedSmallR", cr2w, this);
				}
				return _lowerSpeedSmallR;
			}
			set
			{
				if (_lowerSpeedSmallR == value)
				{
					return;
				}
				_lowerSpeedSmallR = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("lowerSpeedSmallL")] 
		public wCHandle<inkCanvasWidget> LowerSpeedSmallL
		{
			get
			{
				if (_lowerSpeedSmallL == null)
				{
					_lowerSpeedSmallL = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "lowerSpeedSmallL", cr2w, this);
				}
				return _lowerSpeedSmallL;
			}
			set
			{
				if (_lowerSpeedSmallL == value)
				{
					return;
				}
				_lowerSpeedSmallL = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("lowerSpeedFluffR")] 
		public wCHandle<inkImageWidget> LowerSpeedFluffR
		{
			get
			{
				if (_lowerSpeedFluffR == null)
				{
					_lowerSpeedFluffR = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "lowerSpeedFluffR", cr2w, this);
				}
				return _lowerSpeedFluffR;
			}
			set
			{
				if (_lowerSpeedFluffR == value)
				{
					return;
				}
				_lowerSpeedFluffR = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("lowerSpeedFluffL")] 
		public wCHandle<inkImageWidget> LowerSpeedFluffL
		{
			get
			{
				if (_lowerSpeedFluffL == null)
				{
					_lowerSpeedFluffL = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "lowerSpeedFluffL", cr2w, this);
				}
				return _lowerSpeedFluffL;
			}
			set
			{
				if (_lowerSpeedFluffL == value)
				{
					return;
				}
				_lowerSpeedFluffL = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("hudLowerPart")] 
		public wCHandle<inkCanvasWidget> HudLowerPart
		{
			get
			{
				if (_hudLowerPart == null)
				{
					_hudLowerPart = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "hudLowerPart", cr2w, this);
				}
				return _hudLowerPart;
			}
			set
			{
				if (_hudLowerPart == value)
				{
					return;
				}
				_hudLowerPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("lowerfluff_R")] 
		public wCHandle<inkCanvasWidget> Lowerfluff_R
		{
			get
			{
				if (_lowerfluff_R == null)
				{
					_lowerfluff_R = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "lowerfluff_R", cr2w, this);
				}
				return _lowerfluff_R;
			}
			set
			{
				if (_lowerfluff_R == value)
				{
					return;
				}
				_lowerfluff_R = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("lowerfluff_L")] 
		public wCHandle<inkCanvasWidget> Lowerfluff_L
		{
			get
			{
				if (_lowerfluff_L == null)
				{
					_lowerfluff_L = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "lowerfluff_L", cr2w, this);
				}
				return _lowerfluff_L;
			}
			set
			{
				if (_lowerfluff_L == value)
				{
					return;
				}
				_lowerfluff_L = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("HudHideAnimation")] 
		public CHandle<inkanimProxy> HudHideAnimation
		{
			get
			{
				if (_hudHideAnimation == null)
				{
					_hudHideAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "HudHideAnimation", cr2w, this);
				}
				return _hudHideAnimation;
			}
			set
			{
				if (_hudHideAnimation == value)
				{
					return;
				}
				_hudHideAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("HudShowAnimation")] 
		public CHandle<inkanimProxy> HudShowAnimation
		{
			get
			{
				if (_hudShowAnimation == null)
				{
					_hudShowAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "HudShowAnimation", cr2w, this);
				}
				return _hudShowAnimation;
			}
			set
			{
				if (_hudShowAnimation == value)
				{
					return;
				}
				_hudShowAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
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

		[Ordinal(49)] 
		[RED("fluffBlinking")] 
		public CHandle<inkanimController> FluffBlinking
		{
			get
			{
				if (_fluffBlinking == null)
				{
					_fluffBlinking = (CHandle<inkanimController>) CR2WTypeManager.Create("handle:inkanimController", "fluffBlinking", cr2w, this);
				}
				return _fluffBlinking;
			}
			set
			{
				if (_fluffBlinking == value)
				{
					return;
				}
				_fluffBlinking = value;
				PropertySet(this);
			}
		}

		public inkMotorcycleHUDGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
