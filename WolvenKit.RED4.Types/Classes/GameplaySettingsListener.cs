using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplaySettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("userSettings")] 
		public CHandle<userSettingsUserSettings> UserSettings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(2)] 
		[RED("diffSettingsGroup")] 
		public CHandle<userSettingsGroup> DiffSettingsGroup
		{
			get => GetPropertyValue<CHandle<userSettingsGroup>>();
			set => SetPropertyValue<CHandle<userSettingsGroup>>(value);
		}

		[Ordinal(3)] 
		[RED("miscSettingsGroup")] 
		public CHandle<userSettingsGroup> MiscSettingsGroup
		{
			get => GetPropertyValue<CHandle<userSettingsGroup>>();
			set => SetPropertyValue<CHandle<userSettingsGroup>>(value);
		}

		[Ordinal(4)] 
		[RED("controlsGroup")] 
		public CHandle<userSettingsGroup> ControlsGroup
		{
			get => GetPropertyValue<CHandle<userSettingsGroup>>();
			set => SetPropertyValue<CHandle<userSettingsGroup>>(value);
		}

		[Ordinal(5)] 
		[RED("hudGroup")] 
		public CHandle<userSettingsGroup> HudGroup
		{
			get => GetPropertyValue<CHandle<userSettingsGroup>>();
			set => SetPropertyValue<CHandle<userSettingsGroup>>(value);
		}

		[Ordinal(6)] 
		[RED("additiveCameraMovements")] 
		public CFloat AdditiveCameraMovements
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("isFastForwardByLine")] 
		public CBool IsFastForwardByLine
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("movementDodgeEnabled")] 
		public CBool MovementDodgeEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("InputHintsEnabled")] 
		public CBool InputHintsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("additiveCameraGroupName")] 
		public CName AdditiveCameraGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("fastForwardGroupName")] 
		public CName FastForwardGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("movementDodgeGroupName")] 
		public CName MovementDodgeGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("difficultyPath")] 
		public CName DifficultyPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("miscPath")] 
		public CName MiscPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("controlsPath")] 
		public CName ControlsPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("hudPath")] 
		public CName HudPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("hintsName")] 
		public CName HintsName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public GameplaySettingsListener()
		{
			AdditiveCameraGroupName = "AdditiveCameraMovements";
			FastForwardGroupName = "FastForward";
			MovementDodgeGroupName = "MovementDodge";
			DifficultyPath = "/gameplay/difficulty";
			MiscPath = "/gameplay/misc";
			ControlsPath = "/controls";
			HudPath = "/interface/hud";
			HintsName = "input_hints";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
