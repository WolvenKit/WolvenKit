using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVcarGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("activeVehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(3)] 
		[RED("vehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(4)] 
		[RED("mountBBConnectionId")] 
		public CHandle<redCallbackObject> MountBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("speedBBConnectionId")] 
		public CHandle<redCallbackObject> SpeedBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("rpmMaxBBConnectionId")] 
		public CHandle<redCallbackObject> RpmMaxBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("autopilotOnId")] 
		public CHandle<redCallbackObject> AutopilotOnId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("playerVehStateId")] 
		public CHandle<redCallbackObject> PlayerVehStateId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(10)] 
		[RED("isInAutoPilot")] 
		public CBool IsInAutoPilot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("isInCombat")] 
		public CBool IsInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("wasCombat")] 
		public CBool WasCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCanvasWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(14)] 
		[RED("windowWidget")] 
		public CWeakHandle<inkCanvasWidget> WindowWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("speedTextWidget")] 
		public CWeakHandle<inkTextWidget> SpeedTextWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(16)] 
		[RED("rpmGaugeFullWidget")] 
		public CWeakHandle<inkImageWidget> RpmGaugeFullWidget
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(17)] 
		[RED("rpmGaugeMaxSize")] 
		public Vector2 RpmGaugeMaxSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(18)] 
		[RED("interiorRootWidget")] 
		public CWeakHandle<inkCanvasWidget> InteriorRootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("interiorRPMWidget")] 
		public CWeakHandle<inkCanvasWidget> InteriorRPMWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(20)] 
		[RED("interiorFluff1Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff1Widget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("interiorFluff2Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff2Widget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(22)] 
		[RED("interiorFluff3Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff3Widget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(23)] 
		[RED("interiorFluff4Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff4Widget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(24)] 
		[RED("interiorFluff5Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff5Widget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(25)] 
		[RED("interiorFluff1Anim1Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff1Anim1Widget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(26)] 
		[RED("interiorFluff1Anim2Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff1Anim2Widget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("interiorFluff2Anim1Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff2Anim1Widget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(28)] 
		[RED("interiorFluff2Anim2Widget")] 
		public CWeakHandle<inkCanvasWidget> InteriorFluff2Anim2Widget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(29)] 
		[RED("activeChunks")] 
		public CInt32 ActiveChunks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(30)] 
		[RED("animFadeOutProxy")] 
		public CHandle<inkanimProxy> AnimFadeOutProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(31)] 
		[RED("anim_exterior_fadein")] 
		public CHandle<inkanimDefinition> Anim_exterior_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(32)] 
		[RED("anim_exterior_fadeout")] 
		public CHandle<inkanimDefinition> Anim_exterior_fadeout
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(33)] 
		[RED("anim_interior_fadeout")] 
		public CHandle<inkanimDefinition> Anim_interior_fadeout
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(34)] 
		[RED("anim_interior_rpm_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_rpm_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(35)] 
		[RED("anim_interior_fluff1_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff1_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(36)] 
		[RED("anim_interior_fluff2_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff2_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(37)] 
		[RED("anim_interior_fluff3_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff3_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(38)] 
		[RED("anim_interior_fluff4_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff4_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(39)] 
		[RED("anim_interior_fluff5_fadein")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff5_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(40)] 
		[RED("animFluffFadeInProxy")] 
		public CHandle<inkanimProxy> AnimFluffFadeInProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(41)] 
		[RED("anim_interior_fluff1_anim1")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff1_anim1
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(42)] 
		[RED("anim_interior_fluff1_anim2")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff1_anim2
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(43)] 
		[RED("anim_interior_fluff2_anim1")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff2_anim1
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(44)] 
		[RED("anim_interior_fluff2_anim2")] 
		public CHandle<inkanimDefinition> Anim_interior_fluff2_anim2
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(45)] 
		[RED("fluff1animOptions1")] 
		public inkanimPlaybackOptions Fluff1animOptions1
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(46)] 
		[RED("fluff1animOptions2")] 
		public inkanimPlaybackOptions Fluff1animOptions2
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(47)] 
		[RED("fluff2animOptions1")] 
		public inkanimPlaybackOptions Fluff2animOptions1
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(48)] 
		[RED("fluff2animOptions2")] 
		public inkanimPlaybackOptions Fluff2animOptions2
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(49)] 
		[RED("isWindow")] 
		public CBool IsWindow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("isInterior")] 
		public CBool IsInterior
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("hasSpeed")] 
		public CBool HasSpeed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("hasRPM")] 
		public CBool HasRPM
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("chunksNumber")] 
		public CInt32 ChunksNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(54)] 
		[RED("dynamicRpmPath")] 
		public CName DynamicRpmPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(55)] 
		[RED("rpmPerChunk")] 
		public CInt32 RpmPerChunk
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(56)] 
		[RED("hasRevMax")] 
		public CBool HasRevMax
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("revMaxPath")] 
		public CName RevMaxPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(58)] 
		[RED("revMaxChunk")] 
		public CInt32 RevMaxChunk
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(59)] 
		[RED("windowWidgetPath")] 
		public CName WindowWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(60)] 
		[RED("interiorWidgetPath")] 
		public CName InteriorWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(61)] 
		[RED("interiorRPMWidgetPath")] 
		public CName InteriorRPMWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(62)] 
		[RED("interiorFluff1WidgetPath")] 
		public CName InteriorFluff1WidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(63)] 
		[RED("interiorFluff2WidgetPath")] 
		public CName InteriorFluff2WidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(64)] 
		[RED("interiorFluff3WidgetPath")] 
		public CName InteriorFluff3WidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(65)] 
		[RED("interiorFluff4WidgetPath")] 
		public CName InteriorFluff4WidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(66)] 
		[RED("interiorFluff5WidgetPath")] 
		public CName InteriorFluff5WidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(67)] 
		[RED("interiorFluff1Anim1WidgetPath")] 
		public CName InteriorFluff1Anim1WidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(68)] 
		[RED("interiorFluff1Anim2WidgetPath")] 
		public CName InteriorFluff1Anim2WidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(69)] 
		[RED("interiorFluff2Anim1WidgetPath")] 
		public CName InteriorFluff2Anim1WidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(70)] 
		[RED("interiorFluff2Anim2WidgetPath")] 
		public CName InteriorFluff2Anim2WidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public vehicleVcarGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
