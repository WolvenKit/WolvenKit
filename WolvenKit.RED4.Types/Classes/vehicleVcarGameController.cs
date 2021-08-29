using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleVcarGameController : gameuiWidgetGameController
	{
		private CWeakHandle<gameIBlackboard> _activeVehicleBlackboard;
		private CWeakHandle<gameIBlackboard> _vehicleBlackboard;
		private CHandle<redCallbackObject> _mountBBConnectionId;
		private CHandle<redCallbackObject> _speedBBConnectionId;
		private CHandle<redCallbackObject> _rpmValueBBConnectionId;
		private CHandle<redCallbackObject> _rpmMaxBBConnectionId;
		private CHandle<redCallbackObject> _autopilotOnId;
		private CHandle<redCallbackObject> _playerVehStateId;
		private CBool _isInAutoPilot;
		private CBool _isInCombat;
		private CBool _wasCombat;
		private CWeakHandle<inkCanvasWidget> _rootWidget;
		private CWeakHandle<inkCanvasWidget> _windowWidget;
		private CWeakHandle<inkTextWidget> _speedTextWidget;
		private CWeakHandle<inkImageWidget> _rpmGaugeFullWidget;
		private Vector2 _rpmGaugeMaxSize;
		private CWeakHandle<inkCanvasWidget> _interiorRootWidget;
		private CWeakHandle<inkCanvasWidget> _interiorRPMWidget;
		private CWeakHandle<inkCanvasWidget> _interiorFluff1Widget;
		private CWeakHandle<inkCanvasWidget> _interiorFluff2Widget;
		private CWeakHandle<inkCanvasWidget> _interiorFluff3Widget;
		private CWeakHandle<inkCanvasWidget> _interiorFluff4Widget;
		private CWeakHandle<inkCanvasWidget> _interiorFluff5Widget;
		private CWeakHandle<inkCanvasWidget> _interiorFluff1Anim1Widget;
		private CWeakHandle<inkCanvasWidget> _interiorFluff1Anim2Widget;
		private CWeakHandle<inkCanvasWidget> _interiorFluff2Anim1Widget;
		private CWeakHandle<inkCanvasWidget> _interiorFluff2Anim2Widget;
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
		public CWeakHandle<gameIBlackboard> ActiveVehicleBlackboard
		{
			get => GetProperty(ref _activeVehicleBlackboard);
			set => SetProperty(ref _activeVehicleBlackboard, value);
		}

		[Ordinal(3)] 
		[RED("vehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetProperty(ref _vehicleBlackboard);
			set => SetProperty(ref _vehicleBlackboard, value);
		}

		[Ordinal(4)] 
		[RED("mountBBConnectionId")] 
		public CHandle<redCallbackObject> MountBBConnectionId
		{
			get => GetProperty(ref _mountBBConnectionId);
			set => SetProperty(ref _mountBBConnectionId, value);
		}

		[Ordinal(5)] 
		[RED("speedBBConnectionId")] 
		public CHandle<redCallbackObject> SpeedBBConnectionId
		{
			get => GetProperty(ref _speedBBConnectionId);
			set => SetProperty(ref _speedBBConnectionId, value);
		}

		[Ordinal(6)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetProperty(ref _rpmValueBBConnectionId);
			set => SetProperty(ref _rpmValueBBConnectionId, value);
		}

		[Ordinal(7)] 
		[RED("rpmMaxBBConnectionId")] 
		public CHandle<redCallbackObject> RpmMaxBBConnectionId
		{
			get => GetProperty(ref _rpmMaxBBConnectionId);
			set => SetProperty(ref _rpmMaxBBConnectionId, value);
		}

		[Ordinal(8)] 
		[RED("autopilotOnId")] 
		public CHandle<redCallbackObject> AutopilotOnId
		{
			get => GetProperty(ref _autopilotOnId);
			set => SetProperty(ref _autopilotOnId, value);
		}

		[Ordinal(9)] 
		[RED("playerVehStateId")] 
		public CHandle<redCallbackObject> PlayerVehStateId
		{
			get => GetProperty(ref _playerVehStateId);
			set => SetProperty(ref _playerVehStateId, value);
		}

		[Ordinal(10)] 
		[RED("isInAutoPilot")] 
		public CBool IsInAutoPilot
		{
			get => GetProperty(ref _isInAutoPilot);
			set => SetProperty(ref _isInAutoPilot, value);
		}

		[Ordinal(11)] 
		[RED("isInCombat")] 
		public CBool IsInCombat
		{
			get => GetProperty(ref _isInCombat);
			set => SetProperty(ref _isInCombat, value);
		}

		[Ordinal(12)] 
		[RED("wasCombat")] 
		public CBool WasCombat
		{
			get => GetProperty(ref _wasCombat);
			set => SetProperty(ref _wasCombat, value);
		}

		[Ordinal(13)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCanvasWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(14)] 
		[RED("windowWidget")] 
		public CWeakHandle<inkCanvasWidget> WindowWidget
		{
			get => GetProperty(ref _windowWidget);
			set => SetProperty(ref _windowWidget, value);
		}

		[Ordinal(15)] 
		[RED("speedTextWidget")] 
		public CWeakHandle<inkTextWidget> SpeedTextWidget
		{
			get => GetProperty(ref _speedTextWidget);
			set => SetProperty(ref _speedTextWidget, value);
		}

		[Ordinal(16)] 
		[RED("rpmGaugeFullWidget")] 
		public CWeakHandle<inkImageWidget> RpmGaugeFullWidget
		{
			get => GetProperty(ref _rpmGaugeFullWidget);
			set => SetProperty(ref _rpmGaugeFullWidget, value);
		}

		[Ordinal(17)] 
		[RED("rpmGaugeMaxSize")] 
		public Vector2 RpmGaugeMaxSize
		{
			get => GetProperty(ref _rpmGaugeMaxSize);
			set => SetProperty(ref _rpmGaugeMaxSize, value);
		}

		[Ordinal(18)] 
		[RED("interiorRootWidget")] 
		public CWeakHandle<inkCanvasWidget> InteriorRootWidget
		{
			get => GetProperty(ref _interiorRootWidget);
			set => SetProperty(ref _interiorRootWidget, value);
		}

		[Ordinal(19)] 
		[RED("interiorRPMWidget")] 
		public CWeakHandle<inkCanvasWidget> InteriorRPMWidget
		{
			get => GetProperty(ref _interiorRPMWidget);
			set => SetProperty(ref _interiorRPMWidget, value);
		}

		[Ordinal(20)] 
		[RED("interiorFluff1Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff1Widget
		{
			get => GetProperty(ref _interiorFluff1Widget);
			set => SetProperty(ref _interiorFluff1Widget, value);
		}

		[Ordinal(21)] 
		[RED("interiorFluff2Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff2Widget
		{
			get => GetProperty(ref _interiorFluff2Widget);
			set => SetProperty(ref _interiorFluff2Widget, value);
		}

		[Ordinal(22)] 
		[RED("interiorFluff3Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff3Widget
		{
			get => GetProperty(ref _interiorFluff3Widget);
			set => SetProperty(ref _interiorFluff3Widget, value);
		}

		[Ordinal(23)] 
		[RED("interiorFluff4Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff4Widget
		{
			get => GetProperty(ref _interiorFluff4Widget);
			set => SetProperty(ref _interiorFluff4Widget, value);
		}

		[Ordinal(24)] 
		[RED("interiorFluff5Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff5Widget
		{
			get => GetProperty(ref _interiorFluff5Widget);
			set => SetProperty(ref _interiorFluff5Widget, value);
		}

		[Ordinal(25)] 
		[RED("interiorFluff1Anim1Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff1Anim1Widget
		{
			get => GetProperty(ref _interiorFluff1Anim1Widget);
			set => SetProperty(ref _interiorFluff1Anim1Widget, value);
		}

		[Ordinal(26)] 
		[RED("interiorFluff1Anim2Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff1Anim2Widget
		{
			get => GetProperty(ref _interiorFluff1Anim2Widget);
			set => SetProperty(ref _interiorFluff1Anim2Widget, value);
		}

		[Ordinal(27)] 
		[RED("interiorFluff2Anim1Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff2Anim1Widget
		{
			get => GetProperty(ref _interiorFluff2Anim1Widget);
			set => SetProperty(ref _interiorFluff2Anim1Widget, value);
		}

		[Ordinal(28)] 
		[RED("interiorFluff2Anim2Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff2Anim2Widget
		{
			get => GetProperty(ref _interiorFluff2Anim2Widget);
			set => SetProperty(ref _interiorFluff2Anim2Widget, value);
		}

		[Ordinal(29)] 
		[RED("activeChunks")] 
		public CInt32 ActiveChunks
		{
			get => GetProperty(ref _activeChunks);
			set => SetProperty(ref _activeChunks, value);
		}

		[Ordinal(30)] 
		[RED("animFadeOutProxy")] 
		public CHandle<inkanimProxy> AnimFadeOutProxy
		{
			get => GetProperty(ref _animFadeOutProxy);
			set => SetProperty(ref _animFadeOutProxy, value);
		}

		[Ordinal(31)] 
		[RED("anim_exterior_fadein")] 
		public CHandle<inkanimDefinition> Anim_exterior_fadein
		{
			get => GetProperty(ref _anim_exterior_fadein);
			set => SetProperty(ref _anim_exterior_fadein, value);
		}

		[Ordinal(32)] 
		[RED("anim_exterior_fadeout")] 
		public CHandle<inkanimDefinition> Anim_exterior_fadeout
		{
			get => GetProperty(ref _anim_exterior_fadeout);
			set => SetProperty(ref _anim_exterior_fadeout, value);
		}

		[Ordinal(33)] 
		[RED("anim_interior_fadeout")] 
		public CHandle<inkanimDefinition> Anim_interior_fadeout
		{
			get => GetProperty(ref _anim_interior_fadeout);
			set => SetProperty(ref _anim_interior_fadeout, value);
		}

		[Ordinal(34)] 
		[RED("anim_interior_rpm_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_rpm_fadein
		{
			get => GetProperty(ref _anim_interior_rpm_fadein);
			set => SetProperty(ref _anim_interior_rpm_fadein, value);
		}

		[Ordinal(35)] 
		[RED("anim_interior_fluff1_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff1_fadein
		{
			get => GetProperty(ref _anim_interior_fluff1_fadein);
			set => SetProperty(ref _anim_interior_fluff1_fadein, value);
		}

		[Ordinal(36)] 
		[RED("anim_interior_fluff2_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff2_fadein
		{
			get => GetProperty(ref _anim_interior_fluff2_fadein);
			set => SetProperty(ref _anim_interior_fluff2_fadein, value);
		}

		[Ordinal(37)] 
		[RED("anim_interior_fluff3_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff3_fadein
		{
			get => GetProperty(ref _anim_interior_fluff3_fadein);
			set => SetProperty(ref _anim_interior_fluff3_fadein, value);
		}

		[Ordinal(38)] 
		[RED("anim_interior_fluff4_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff4_fadein
		{
			get => GetProperty(ref _anim_interior_fluff4_fadein);
			set => SetProperty(ref _anim_interior_fluff4_fadein, value);
		}

		[Ordinal(39)] 
		[RED("anim_interior_fluff5_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff5_fadein
		{
			get => GetProperty(ref _anim_interior_fluff5_fadein);
			set => SetProperty(ref _anim_interior_fluff5_fadein, value);
		}

		[Ordinal(40)] 
		[RED("animFluffFadeInProxy")] 
		public CHandle<inkanimProxy> AnimFluffFadeInProxy
		{
			get => GetProperty(ref _animFluffFadeInProxy);
			set => SetProperty(ref _animFluffFadeInProxy, value);
		}

		[Ordinal(41)] 
		[RED("anim_interior_fluff1_anim1")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff1_anim1
		{
			get => GetProperty(ref _anim_interior_fluff1_anim1);
			set => SetProperty(ref _anim_interior_fluff1_anim1, value);
		}

		[Ordinal(42)] 
		[RED("anim_interior_fluff1_anim2")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff1_anim2
		{
			get => GetProperty(ref _anim_interior_fluff1_anim2);
			set => SetProperty(ref _anim_interior_fluff1_anim2, value);
		}

		[Ordinal(43)] 
		[RED("anim_interior_fluff2_anim1")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff2_anim1
		{
			get => GetProperty(ref _anim_interior_fluff2_anim1);
			set => SetProperty(ref _anim_interior_fluff2_anim1, value);
		}

		[Ordinal(44)] 
		[RED("anim_interior_fluff2_anim2")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff2_anim2
		{
			get => GetProperty(ref _anim_interior_fluff2_anim2);
			set => SetProperty(ref _anim_interior_fluff2_anim2, value);
		}

		[Ordinal(45)] 
		[RED("fluff1animOptions1")] 
		public inkanimPlaybackOptions Fluff1animOptions1
		{
			get => GetProperty(ref _fluff1animOptions1);
			set => SetProperty(ref _fluff1animOptions1, value);
		}

		[Ordinal(46)] 
		[RED("fluff1animOptions2")] 
		public inkanimPlaybackOptions Fluff1animOptions2
		{
			get => GetProperty(ref _fluff1animOptions2);
			set => SetProperty(ref _fluff1animOptions2, value);
		}

		[Ordinal(47)] 
		[RED("fluff2animOptions1")] 
		public inkanimPlaybackOptions Fluff2animOptions1
		{
			get => GetProperty(ref _fluff2animOptions1);
			set => SetProperty(ref _fluff2animOptions1, value);
		}

		[Ordinal(48)] 
		[RED("fluff2animOptions2")] 
		public inkanimPlaybackOptions Fluff2animOptions2
		{
			get => GetProperty(ref _fluff2animOptions2);
			set => SetProperty(ref _fluff2animOptions2, value);
		}

		[Ordinal(49)] 
		[RED("isWindow")] 
		public CBool IsWindow
		{
			get => GetProperty(ref _isWindow);
			set => SetProperty(ref _isWindow, value);
		}

		[Ordinal(50)] 
		[RED("isInterior")] 
		public CBool IsInterior
		{
			get => GetProperty(ref _isInterior);
			set => SetProperty(ref _isInterior, value);
		}

		[Ordinal(51)] 
		[RED("hasSpeed")] 
		public CBool HasSpeed
		{
			get => GetProperty(ref _hasSpeed);
			set => SetProperty(ref _hasSpeed, value);
		}

		[Ordinal(52)] 
		[RED("hasRPM")] 
		public CBool HasRPM
		{
			get => GetProperty(ref _hasRPM);
			set => SetProperty(ref _hasRPM, value);
		}

		[Ordinal(53)] 
		[RED("chunksNumber")] 
		public CInt32 ChunksNumber
		{
			get => GetProperty(ref _chunksNumber);
			set => SetProperty(ref _chunksNumber, value);
		}

		[Ordinal(54)] 
		[RED("dynamicRpmPath")] 
		public CName DynamicRpmPath
		{
			get => GetProperty(ref _dynamicRpmPath);
			set => SetProperty(ref _dynamicRpmPath, value);
		}

		[Ordinal(55)] 
		[RED("rpmPerChunk")] 
		public CInt32 RpmPerChunk
		{
			get => GetProperty(ref _rpmPerChunk);
			set => SetProperty(ref _rpmPerChunk, value);
		}

		[Ordinal(56)] 
		[RED("hasRevMax")] 
		public CBool HasRevMax
		{
			get => GetProperty(ref _hasRevMax);
			set => SetProperty(ref _hasRevMax, value);
		}

		[Ordinal(57)] 
		[RED("revMaxPath")] 
		public CName RevMaxPath
		{
			get => GetProperty(ref _revMaxPath);
			set => SetProperty(ref _revMaxPath, value);
		}

		[Ordinal(58)] 
		[RED("revMaxChunk")] 
		public CInt32 RevMaxChunk
		{
			get => GetProperty(ref _revMaxChunk);
			set => SetProperty(ref _revMaxChunk, value);
		}

		[Ordinal(59)] 
		[RED("windowWidgetPath")] 
		public CName WindowWidgetPath
		{
			get => GetProperty(ref _windowWidgetPath);
			set => SetProperty(ref _windowWidgetPath, value);
		}

		[Ordinal(60)] 
		[RED("interiorWidgetPath")] 
		public CName InteriorWidgetPath
		{
			get => GetProperty(ref _interiorWidgetPath);
			set => SetProperty(ref _interiorWidgetPath, value);
		}

		[Ordinal(61)] 
		[RED("interiorRPMWidgetPath")] 
		public CName InteriorRPMWidgetPath
		{
			get => GetProperty(ref _interiorRPMWidgetPath);
			set => SetProperty(ref _interiorRPMWidgetPath, value);
		}

		[Ordinal(62)] 
		[RED("interiorFluff1WidgetPath")] 
		public CName InteriorFluff1WidgetPath
		{
			get => GetProperty(ref _interiorFluff1WidgetPath);
			set => SetProperty(ref _interiorFluff1WidgetPath, value);
		}

		[Ordinal(63)] 
		[RED("interiorFluff2WidgetPath")] 
		public CName InteriorFluff2WidgetPath
		{
			get => GetProperty(ref _interiorFluff2WidgetPath);
			set => SetProperty(ref _interiorFluff2WidgetPath, value);
		}

		[Ordinal(64)] 
		[RED("interiorFluff3WidgetPath")] 
		public CName InteriorFluff3WidgetPath
		{
			get => GetProperty(ref _interiorFluff3WidgetPath);
			set => SetProperty(ref _interiorFluff3WidgetPath, value);
		}

		[Ordinal(65)] 
		[RED("interiorFluff4WidgetPath")] 
		public CName InteriorFluff4WidgetPath
		{
			get => GetProperty(ref _interiorFluff4WidgetPath);
			set => SetProperty(ref _interiorFluff4WidgetPath, value);
		}

		[Ordinal(66)] 
		[RED("interiorFluff5WidgetPath")] 
		public CName InteriorFluff5WidgetPath
		{
			get => GetProperty(ref _interiorFluff5WidgetPath);
			set => SetProperty(ref _interiorFluff5WidgetPath, value);
		}

		[Ordinal(67)] 
		[RED("interiorFluff1Anim1WidgetPath")] 
		public CName InteriorFluff1Anim1WidgetPath
		{
			get => GetProperty(ref _interiorFluff1Anim1WidgetPath);
			set => SetProperty(ref _interiorFluff1Anim1WidgetPath, value);
		}

		[Ordinal(68)] 
		[RED("interiorFluff1Anim2WidgetPath")] 
		public CName InteriorFluff1Anim2WidgetPath
		{
			get => GetProperty(ref _interiorFluff1Anim2WidgetPath);
			set => SetProperty(ref _interiorFluff1Anim2WidgetPath, value);
		}

		[Ordinal(69)] 
		[RED("interiorFluff2Anim1WidgetPath")] 
		public CName InteriorFluff2Anim1WidgetPath
		{
			get => GetProperty(ref _interiorFluff2Anim1WidgetPath);
			set => SetProperty(ref _interiorFluff2Anim1WidgetPath, value);
		}

		[Ordinal(70)] 
		[RED("interiorFluff2Anim2WidgetPath")] 
		public CName InteriorFluff2Anim2WidgetPath
		{
			get => GetProperty(ref _interiorFluff2Anim2WidgetPath);
			set => SetProperty(ref _interiorFluff2Anim2WidgetPath, value);
		}
	}
}
