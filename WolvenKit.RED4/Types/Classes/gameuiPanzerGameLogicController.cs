using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPanzerGameLogicController : gameuiSideScrollerMiniGameLogicControllerAdvanced
	{
		[Ordinal(9)] 
		[RED("gameOverDelay")] 
		public CFloat GameOverDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("mainMenuLibraryName")] 
		public CName MainMenuLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("scoreboardLibraryName")] 
		public CName ScoreboardLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("panelsLayer")] 
		public CName PanelsLayer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("gameLayer")] 
		public CName GameLayer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("cloudsLayer")] 
		public CName CloudsLayer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("backgroundLibraryName")] 
		public CName BackgroundLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("cloudsLibraryNames")] 
		public CArray<CName> CloudsLibraryNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(17)] 
		[RED("minCloudSpawnInterval")] 
		public CFloat MinCloudSpawnInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("maxCloudSpawnInterval")] 
		public CFloat MaxCloudSpawnInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("minCloudSpeed")] 
		public CFloat MinCloudSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("maxCloudSpeed")] 
		public CFloat MaxCloudSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("scoreCounter")] 
		public inkTextWidgetReference ScoreCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("livesCounter")] 
		public inkTextWidgetReference LivesCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("moveUpKey")] 
		public CName MoveUpKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("moveDownKey")] 
		public CName MoveDownKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("moveLeftKey")] 
		public CName MoveLeftKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(26)] 
		[RED("moveRightKey")] 
		public CName MoveRightKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(27)] 
		[RED("shootKey")] 
		public CName ShootKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(28)] 
		[RED("backKey")] 
		public CName BackKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(29)] 
		[RED("submitKey")] 
		public CName SubmitKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("axisDeadZone")] 
		public CFloat AxisDeadZone
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("moveXAxis")] 
		public CName MoveXAxis
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(32)] 
		[RED("moveYAxis")] 
		public CName MoveYAxis
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("shootAxis")] 
		public CName ShootAxis
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("droneLibraryName")] 
		public CName DroneLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("minDroneSpawnInterval")] 
		public CFloat MinDroneSpawnInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("maxDroneSpawnInterval")] 
		public CFloat MaxDroneSpawnInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("avLibraryName")] 
		public CName AvLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(38)] 
		[RED("minAvSpawnInterval")] 
		public CFloat MinAvSpawnInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("maxAvSpawnInterval")] 
		public CFloat MaxAvSpawnInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiPanzerGameLogicController()
		{
			PlayerColliderPositionOffset = new Vector2();
			PlayerColliderSizeOffset = new Vector2();
			GameplayRoot = new inkCompoundWidgetReference();
			Layers = new();
			CheatCodes = new();
			AcceptableCheatKeys = new() { "CameraStepDown", "CameraStepUp", "UI_MoveUp", "UI_MoveDown", "UI_MoveLeft", "UI_MoveRight" };
			GameOverDelay = 2.000000F;
			CloudsLibraryNames = new();
			ScoreCounter = new inkTextWidgetReference();
			LivesCounter = new inkTextWidgetReference();
			MoveUpKey = "CameraStepPitchUp";
			MoveDownKey = "CameraStepPitchDown";
			MoveLeftKey = "CameraStepYawLeft";
			MoveRightKey = "CameraStepYawRight";
			ShootKey = "CameraStepUp";
			BackKey = "CameraStepDown";
			SubmitKey = "click";
			AxisDeadZone = 0.050000F;
			MoveXAxis = "left_stick_x";
			MoveYAxis = "left_stick_y";
			ShootAxis = "right_trigger";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
