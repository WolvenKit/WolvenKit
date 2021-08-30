using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplaySettingsListener : userSettingsVarListener
	{
		private CWeakHandle<PlayerPuppet> _player;
		private CHandle<userSettingsUserSettings> _userSettings;
		private CHandle<userSettingsGroup> _diffSettingsGroup;
		private CHandle<userSettingsGroup> _miscSettingsGroup;
		private CHandle<userSettingsGroup> _controlsGroup;
		private CHandle<userSettingsGroup> _hudGroup;
		private CFloat _additiveCameraMovements;
		private CBool _isFastForwardByLine;
		private CBool _movementDodgeEnabled;
		private CBool _inputHintsEnabled;
		private CName _additiveCameraGroupName;
		private CName _fastForwardGroupName;
		private CName _movementDodgeGroupName;
		private CName _difficultyPath;
		private CName _miscPath;
		private CName _controlsPath;
		private CName _hudPath;
		private CName _hintsName;

		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("userSettings")] 
		public CHandle<userSettingsUserSettings> UserSettings
		{
			get => GetProperty(ref _userSettings);
			set => SetProperty(ref _userSettings, value);
		}

		[Ordinal(2)] 
		[RED("diffSettingsGroup")] 
		public CHandle<userSettingsGroup> DiffSettingsGroup
		{
			get => GetProperty(ref _diffSettingsGroup);
			set => SetProperty(ref _diffSettingsGroup, value);
		}

		[Ordinal(3)] 
		[RED("miscSettingsGroup")] 
		public CHandle<userSettingsGroup> MiscSettingsGroup
		{
			get => GetProperty(ref _miscSettingsGroup);
			set => SetProperty(ref _miscSettingsGroup, value);
		}

		[Ordinal(4)] 
		[RED("controlsGroup")] 
		public CHandle<userSettingsGroup> ControlsGroup
		{
			get => GetProperty(ref _controlsGroup);
			set => SetProperty(ref _controlsGroup, value);
		}

		[Ordinal(5)] 
		[RED("hudGroup")] 
		public CHandle<userSettingsGroup> HudGroup
		{
			get => GetProperty(ref _hudGroup);
			set => SetProperty(ref _hudGroup, value);
		}

		[Ordinal(6)] 
		[RED("additiveCameraMovements")] 
		public CFloat AdditiveCameraMovements
		{
			get => GetProperty(ref _additiveCameraMovements);
			set => SetProperty(ref _additiveCameraMovements, value);
		}

		[Ordinal(7)] 
		[RED("isFastForwardByLine")] 
		public CBool IsFastForwardByLine
		{
			get => GetProperty(ref _isFastForwardByLine);
			set => SetProperty(ref _isFastForwardByLine, value);
		}

		[Ordinal(8)] 
		[RED("movementDodgeEnabled")] 
		public CBool MovementDodgeEnabled
		{
			get => GetProperty(ref _movementDodgeEnabled);
			set => SetProperty(ref _movementDodgeEnabled, value);
		}

		[Ordinal(9)] 
		[RED("InputHintsEnabled")] 
		public CBool InputHintsEnabled
		{
			get => GetProperty(ref _inputHintsEnabled);
			set => SetProperty(ref _inputHintsEnabled, value);
		}

		[Ordinal(10)] 
		[RED("additiveCameraGroupName")] 
		public CName AdditiveCameraGroupName
		{
			get => GetProperty(ref _additiveCameraGroupName);
			set => SetProperty(ref _additiveCameraGroupName, value);
		}

		[Ordinal(11)] 
		[RED("fastForwardGroupName")] 
		public CName FastForwardGroupName
		{
			get => GetProperty(ref _fastForwardGroupName);
			set => SetProperty(ref _fastForwardGroupName, value);
		}

		[Ordinal(12)] 
		[RED("movementDodgeGroupName")] 
		public CName MovementDodgeGroupName
		{
			get => GetProperty(ref _movementDodgeGroupName);
			set => SetProperty(ref _movementDodgeGroupName, value);
		}

		[Ordinal(13)] 
		[RED("difficultyPath")] 
		public CName DifficultyPath
		{
			get => GetProperty(ref _difficultyPath);
			set => SetProperty(ref _difficultyPath, value);
		}

		[Ordinal(14)] 
		[RED("miscPath")] 
		public CName MiscPath
		{
			get => GetProperty(ref _miscPath);
			set => SetProperty(ref _miscPath, value);
		}

		[Ordinal(15)] 
		[RED("controlsPath")] 
		public CName ControlsPath
		{
			get => GetProperty(ref _controlsPath);
			set => SetProperty(ref _controlsPath, value);
		}

		[Ordinal(16)] 
		[RED("hudPath")] 
		public CName HudPath
		{
			get => GetProperty(ref _hudPath);
			set => SetProperty(ref _hudPath, value);
		}

		[Ordinal(17)] 
		[RED("hintsName")] 
		public CName HintsName
		{
			get => GetProperty(ref _hintsName);
			set => SetProperty(ref _hintsName, value);
		}

		public GameplaySettingsListener()
		{
			_additiveCameraGroupName = "AdditiveCameraMovements";
			_fastForwardGroupName = "FastForward";
			_movementDodgeGroupName = "MovementDodge";
			_difficultyPath = "/gameplay/difficulty";
			_miscPath = "/gameplay/misc";
			_controlsPath = "/controls";
			_hudPath = "/interface/hud";
			_hintsName = "input_hints";
		}
	}
}
