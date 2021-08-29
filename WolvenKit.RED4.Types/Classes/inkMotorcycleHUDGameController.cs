using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkMotorcycleHUDGameController : gameuiBaseVehicleHUDGameController
	{
		private CWeakHandle<gameIBlackboard> _vehicleBlackboard;
		private CWeakHandle<gameIBlackboard> _activeVehicleUIBlackboard;
		private CHandle<redCallbackObject> _vehicleBBStateConectionId;
		private CHandle<redCallbackObject> _speedBBConnectionId;
		private CHandle<redCallbackObject> _gearBBConnectionId;
		private CHandle<redCallbackObject> _tppBBConnectionId;
		private CHandle<redCallbackObject> _rpmValueBBConnectionId;
		private CHandle<redCallbackObject> _leanAngleBBConnectionId;
		private CHandle<redCallbackObject> _playerStateBBConnectionId;
		private inkanimPlaybackOptions _playOptionReverse;
		private CWeakHandle<inkCanvasWidget> _rootWidget;
		private CWeakHandle<inkCanvasWidget> _mainCanvas;
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
		private CWeakHandle<inkCanvasWidget> _lower;
		private CWeakHandle<inkCanvasWidget> _lowerSpeedBigR;
		private CWeakHandle<inkCanvasWidget> _lowerSpeedBigL;
		private CWeakHandle<inkCanvasWidget> _lowerSpeedSmallR;
		private CWeakHandle<inkCanvasWidget> _lowerSpeedSmallL;
		private CWeakHandle<inkImageWidget> _lowerSpeedFluffR;
		private CWeakHandle<inkImageWidget> _lowerSpeedFluffL;
		private CWeakHandle<inkCanvasWidget> _hudLowerPart;
		private CWeakHandle<inkCanvasWidget> _lowerfluff_R;
		private CWeakHandle<inkCanvasWidget> _lowerfluff_L;
		private CHandle<inkanimProxy> _hudHideAnimation;
		private CHandle<inkanimProxy> _hudShowAnimation;
		private CHandle<inkanimProxy> _hudRedLineAnimation;
		private CHandle<inkanimController> _fluffBlinking;

		[Ordinal(10)] 
		[RED("vehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetProperty(ref _vehicleBlackboard);
			set => SetProperty(ref _vehicleBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("activeVehicleUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get => GetProperty(ref _activeVehicleUIBlackboard);
			set => SetProperty(ref _activeVehicleUIBlackboard, value);
		}

		[Ordinal(12)] 
		[RED("vehicleBBStateConectionId")] 
		public CHandle<redCallbackObject> VehicleBBStateConectionId
		{
			get => GetProperty(ref _vehicleBBStateConectionId);
			set => SetProperty(ref _vehicleBBStateConectionId, value);
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
		[RED("tppBBConnectionId")] 
		public CHandle<redCallbackObject> TppBBConnectionId
		{
			get => GetProperty(ref _tppBBConnectionId);
			set => SetProperty(ref _tppBBConnectionId, value);
		}

		[Ordinal(16)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetProperty(ref _rpmValueBBConnectionId);
			set => SetProperty(ref _rpmValueBBConnectionId, value);
		}

		[Ordinal(17)] 
		[RED("leanAngleBBConnectionId")] 
		public CHandle<redCallbackObject> LeanAngleBBConnectionId
		{
			get => GetProperty(ref _leanAngleBBConnectionId);
			set => SetProperty(ref _leanAngleBBConnectionId, value);
		}

		[Ordinal(18)] 
		[RED("playerStateBBConnectionId")] 
		public CHandle<redCallbackObject> PlayerStateBBConnectionId
		{
			get => GetProperty(ref _playerStateBBConnectionId);
			set => SetProperty(ref _playerStateBBConnectionId, value);
		}

		[Ordinal(19)] 
		[RED("playOptionReverse")] 
		public inkanimPlaybackOptions PlayOptionReverse
		{
			get => GetProperty(ref _playOptionReverse);
			set => SetProperty(ref _playOptionReverse, value);
		}

		[Ordinal(20)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCanvasWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(21)] 
		[RED("mainCanvas")] 
		public CWeakHandle<inkCanvasWidget> MainCanvas
		{
			get => GetProperty(ref _mainCanvas);
			set => SetProperty(ref _mainCanvas, value);
		}

		[Ordinal(22)] 
		[RED("activeChunks")] 
		public CInt32 ActiveChunks
		{
			get => GetProperty(ref _activeChunks);
			set => SetProperty(ref _activeChunks, value);
		}

		[Ordinal(23)] 
		[RED("chunksNumber")] 
		public CInt32 ChunksNumber
		{
			get => GetProperty(ref _chunksNumber);
			set => SetProperty(ref _chunksNumber, value);
		}

		[Ordinal(24)] 
		[RED("dynamicRpmPath")] 
		public CName DynamicRpmPath
		{
			get => GetProperty(ref _dynamicRpmPath);
			set => SetProperty(ref _dynamicRpmPath, value);
		}

		[Ordinal(25)] 
		[RED("rpmPerChunk")] 
		public CInt32 RpmPerChunk
		{
			get => GetProperty(ref _rpmPerChunk);
			set => SetProperty(ref _rpmPerChunk, value);
		}

		[Ordinal(26)] 
		[RED("hasRevMax")] 
		public CBool HasRevMax
		{
			get => GetProperty(ref _hasRevMax);
			set => SetProperty(ref _hasRevMax, value);
		}

		[Ordinal(27)] 
		[RED("HiResMode")] 
		public CBool HiResMode
		{
			get => GetProperty(ref _hiResMode);
			set => SetProperty(ref _hiResMode, value);
		}

		[Ordinal(28)] 
		[RED("revMaxPath")] 
		public CName RevMaxPath
		{
			get => GetProperty(ref _revMaxPath);
			set => SetProperty(ref _revMaxPath, value);
		}

		[Ordinal(29)] 
		[RED("revMaxChunk")] 
		public CInt32 RevMaxChunk
		{
			get => GetProperty(ref _revMaxChunk);
			set => SetProperty(ref _revMaxChunk, value);
		}

		[Ordinal(30)] 
		[RED("revMax")] 
		public CInt32 RevMax
		{
			get => GetProperty(ref _revMax);
			set => SetProperty(ref _revMax, value);
		}

		[Ordinal(31)] 
		[RED("revRedLine")] 
		public CInt32 RevRedLine
		{
			get => GetProperty(ref _revRedLine);
			set => SetProperty(ref _revRedLine, value);
		}

		[Ordinal(32)] 
		[RED("maxSpeed")] 
		public CInt32 MaxSpeed
		{
			get => GetProperty(ref _maxSpeed);
			set => SetProperty(ref _maxSpeed, value);
		}

		[Ordinal(33)] 
		[RED("speedTextWidget")] 
		public inkTextWidgetReference SpeedTextWidget
		{
			get => GetProperty(ref _speedTextWidget);
			set => SetProperty(ref _speedTextWidget, value);
		}

		[Ordinal(34)] 
		[RED("gearTextWidget")] 
		public inkTextWidgetReference GearTextWidget
		{
			get => GetProperty(ref _gearTextWidget);
			set => SetProperty(ref _gearTextWidget, value);
		}

		[Ordinal(35)] 
		[RED("RPMTextWidget")] 
		public inkTextWidgetReference RPMTextWidget
		{
			get => GetProperty(ref _rPMTextWidget);
			set => SetProperty(ref _rPMTextWidget, value);
		}

		[Ordinal(36)] 
		[RED("lower")] 
		public CWeakHandle<inkCanvasWidget> Lower
		{
			get => GetProperty(ref _lower);
			set => SetProperty(ref _lower, value);
		}

		[Ordinal(37)] 
		[RED("lowerSpeedBigR")] 
		public CWeakHandle<inkCanvasWidget> LowerSpeedBigR
		{
			get => GetProperty(ref _lowerSpeedBigR);
			set => SetProperty(ref _lowerSpeedBigR, value);
		}

		[Ordinal(38)] 
		[RED("lowerSpeedBigL")] 
		public CWeakHandle<inkCanvasWidget> LowerSpeedBigL
		{
			get => GetProperty(ref _lowerSpeedBigL);
			set => SetProperty(ref _lowerSpeedBigL, value);
		}

		[Ordinal(39)] 
		[RED("lowerSpeedSmallR")] 
		public CWeakHandle<inkCanvasWidget> LowerSpeedSmallR
		{
			get => GetProperty(ref _lowerSpeedSmallR);
			set => SetProperty(ref _lowerSpeedSmallR, value);
		}

		[Ordinal(40)] 
		[RED("lowerSpeedSmallL")] 
		public CWeakHandle<inkCanvasWidget> LowerSpeedSmallL
		{
			get => GetProperty(ref _lowerSpeedSmallL);
			set => SetProperty(ref _lowerSpeedSmallL, value);
		}

		[Ordinal(41)] 
		[RED("lowerSpeedFluffR")] 
		public CWeakHandle<inkImageWidget> LowerSpeedFluffR
		{
			get => GetProperty(ref _lowerSpeedFluffR);
			set => SetProperty(ref _lowerSpeedFluffR, value);
		}

		[Ordinal(42)] 
		[RED("lowerSpeedFluffL")] 
		public CWeakHandle<inkImageWidget> LowerSpeedFluffL
		{
			get => GetProperty(ref _lowerSpeedFluffL);
			set => SetProperty(ref _lowerSpeedFluffL, value);
		}

		[Ordinal(43)] 
		[RED("hudLowerPart")] 
		public CWeakHandle<inkCanvasWidget> HudLowerPart
		{
			get => GetProperty(ref _hudLowerPart);
			set => SetProperty(ref _hudLowerPart, value);
		}

		[Ordinal(44)] 
		[RED("lowerfluff_R")] 
		public CWeakHandle<inkCanvasWidget> Lowerfluff_R
		{
			get => GetProperty(ref _lowerfluff_R);
			set => SetProperty(ref _lowerfluff_R, value);
		}

		[Ordinal(45)] 
		[RED("lowerfluff_L")] 
		public CWeakHandle<inkCanvasWidget> Lowerfluff_L
		{
			get => GetProperty(ref _lowerfluff_L);
			set => SetProperty(ref _lowerfluff_L, value);
		}

		[Ordinal(46)] 
		[RED("HudHideAnimation")] 
		public CHandle<inkanimProxy> HudHideAnimation
		{
			get => GetProperty(ref _hudHideAnimation);
			set => SetProperty(ref _hudHideAnimation, value);
		}

		[Ordinal(47)] 
		[RED("HudShowAnimation")] 
		public CHandle<inkanimProxy> HudShowAnimation
		{
			get => GetProperty(ref _hudShowAnimation);
			set => SetProperty(ref _hudShowAnimation, value);
		}

		[Ordinal(48)] 
		[RED("HudRedLineAnimation")] 
		public CHandle<inkanimProxy> HudRedLineAnimation
		{
			get => GetProperty(ref _hudRedLineAnimation);
			set => SetProperty(ref _hudRedLineAnimation, value);
		}

		[Ordinal(49)] 
		[RED("fluffBlinking")] 
		public CHandle<inkanimController> FluffBlinking
		{
			get => GetProperty(ref _fluffBlinking);
			set => SetProperty(ref _fluffBlinking, value);
		}
	}
}
