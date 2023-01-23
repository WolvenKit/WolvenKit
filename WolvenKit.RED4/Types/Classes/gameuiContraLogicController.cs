using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiContraLogicController : gameuiSideScrollerMiniGameLogicControllerAdvanced
	{
		[Ordinal(9)] 
		[RED("playerSpawnHeight")] 
		public CFloat PlayerSpawnHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("mainMenuScreenLibraryName")] 
		public CName MainMenuScreenLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("scoreboardScreenLibraryName")] 
		public CName ScoreboardScreenLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("jumpKey")] 
		public CName JumpKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("goDownKey")] 
		public CName GoDownKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("goLeftKey")] 
		public CName GoLeftKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("goRightKey")] 
		public CName GoRightKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("lieDownKey")] 
		public CName LieDownKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("shootKey")] 
		public CName ShootKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("submitKey")] 
		public CName SubmitKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("axisDeadZone")] 
		public CFloat AxisDeadZone
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("moveXAxis")] 
		public CName MoveXAxis
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("moveYAxis")] 
		public CName MoveYAxis
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("shootTriggerName")] 
		public CName ShootTriggerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("uiLayerName")] 
		public CName UiLayerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("gameLayerName")] 
		public CName GameLayerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("platformLayerName")] 
		public CName PlatformLayerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(26)] 
		[RED("backgroundLayerName")] 
		public CName BackgroundLayerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(27)] 
		[RED("tileLibraryName")] 
		public CName TileLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(28)] 
		[RED("platformLibraryName")] 
		public CName PlatformLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(29)] 
		[RED("platformTexturePartName")] 
		public CName PlatformTexturePartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("RoadTexturePartName")] 
		public CName RoadTexturePartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("middlePlatformMinDistance")] 
		public CFloat MiddlePlatformMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("middlePlatformMaxDistance")] 
		public CFloat MiddlePlatformMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("topPlatformPosition")] 
		public CFloat TopPlatformPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("bottomPlatformPosition")] 
		public CFloat BottomPlatformPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("fenceLibraryName")] 
		public CName FenceLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(36)] 
		[RED("fenceSpawnDistance")] 
		public CFloat FenceSpawnDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiContraLogicController()
		{
			PlayerColliderPositionOffset = new();
			PlayerColliderSizeOffset = new();
			GameplayRoot = new();
			Layers = new();
			CheatCodes = new();
			AcceptableCheatKeys = new() { "CameraStepDown", "CameraStepUp", "UI_MoveUp", "UI_MoveDown", "UI_MoveLeft", "UI_MoveRight" };
			JumpKey = "CameraStepPitchUp";
			GoDownKey = "CameraStepPitchDown";
			GoLeftKey = "CameraStepYawLeft";
			GoRightKey = "CameraStepYawRight";
			SubmitKey = "click";
			AxisDeadZone = 0.050000F;
			MoveXAxis = "left_stick_x";
			MoveYAxis = "left_stick_y";
			ShootTriggerName = "right_trigger";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
