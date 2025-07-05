using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkMotorcycleHUDGameController : gameuiBaseVehicleHUDGameController
	{
		[Ordinal(10)] 
		[RED("vehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("activeVehicleUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(12)] 
		[RED("vehicleBBStateConectionId")] 
		public CHandle<redCallbackObject> VehicleBBStateConectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("speedBBConnectionId")] 
		public CHandle<redCallbackObject> SpeedBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("gearBBConnectionId")] 
		public CHandle<redCallbackObject> GearBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("tppBBConnectionId")] 
		public CHandle<redCallbackObject> TppBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("leanAngleBBConnectionId")] 
		public CHandle<redCallbackObject> LeanAngleBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("playerStateBBConnectionId")] 
		public CHandle<redCallbackObject> PlayerStateBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("playOptionReverse")] 
		public inkanimPlaybackOptions PlayOptionReverse
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(20)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCanvasWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("mainCanvas")] 
		public CWeakHandle<inkCanvasWidget> MainCanvas
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(22)] 
		[RED("activeChunks")] 
		public CInt32 ActiveChunks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("chunksNumber")] 
		public CInt32 ChunksNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("dynamicRpmPath")] 
		public CName DynamicRpmPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("rpmPerChunk")] 
		public CInt32 RpmPerChunk
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(26)] 
		[RED("hasRevMax")] 
		public CBool HasRevMax
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("HiResMode")] 
		public CBool HiResMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("revMaxPath")] 
		public CName RevMaxPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(29)] 
		[RED("revMaxChunk")] 
		public CInt32 RevMaxChunk
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(30)] 
		[RED("revMax")] 
		public CInt32 RevMax
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(31)] 
		[RED("revRedLine")] 
		public CInt32 RevRedLine
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(32)] 
		[RED("maxSpeed")] 
		public CInt32 MaxSpeed
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(33)] 
		[RED("speedTextWidget")] 
		public inkTextWidgetReference SpeedTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("gearTextWidget")] 
		public inkTextWidgetReference GearTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("RPMTextWidget")] 
		public inkTextWidgetReference RPMTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("lower")] 
		public CWeakHandle<inkCanvasWidget> Lower
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(37)] 
		[RED("lowerSpeedBigR")] 
		public CWeakHandle<inkCanvasWidget> LowerSpeedBigR
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(38)] 
		[RED("lowerSpeedBigL")] 
		public CWeakHandle<inkCanvasWidget> LowerSpeedBigL
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(39)] 
		[RED("lowerSpeedSmallR")] 
		public CWeakHandle<inkCanvasWidget> LowerSpeedSmallR
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(40)] 
		[RED("lowerSpeedSmallL")] 
		public CWeakHandle<inkCanvasWidget> LowerSpeedSmallL
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(41)] 
		[RED("lowerSpeedFluffR")] 
		public CWeakHandle<inkImageWidget> LowerSpeedFluffR
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(42)] 
		[RED("lowerSpeedFluffL")] 
		public CWeakHandle<inkImageWidget> LowerSpeedFluffL
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(43)] 
		[RED("hudLowerPart")] 
		public CWeakHandle<inkCanvasWidget> HudLowerPart
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(44)] 
		[RED("lowerfluff_R")] 
		public CWeakHandle<inkCanvasWidget> Lowerfluff_R
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(45)] 
		[RED("lowerfluff_L")] 
		public CWeakHandle<inkCanvasWidget> Lowerfluff_L
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(46)] 
		[RED("HudHideAnimation")] 
		public CHandle<inkanimProxy> HudHideAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(47)] 
		[RED("HudShowAnimation")] 
		public CHandle<inkanimProxy> HudShowAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(48)] 
		[RED("HudRedLineAnimation")] 
		public CHandle<inkanimProxy> HudRedLineAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(49)] 
		[RED("fluffBlinking")] 
		public CHandle<inkanimController> FluffBlinking
		{
			get => GetPropertyValue<CHandle<inkanimController>>();
			set => SetPropertyValue<CHandle<inkanimController>>(value);
		}

		public inkMotorcycleHUDGameController()
		{
			PlayOptionReverse = new inkanimPlaybackOptions { CustomTimeDilation = 1.000000F };
			SpeedTextWidget = new inkTextWidgetReference();
			GearTextWidget = new inkTextWidgetReference();
			RPMTextWidget = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
