using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplaySettingsListener : userSettingsVarListener
	{
		private wCHandle<PlayerPuppet> _player;
		private CHandle<userSettingsUserSettings> _userSettings;
		private CHandle<userSettingsGroup> _diffSettingsGroup;
		private CHandle<userSettingsGroup> _miscSettingsGroup;
		private CHandle<userSettingsGroup> _controlsGroup;
		private CFloat _additiveCameraMovements;
		private CBool _isFastForwardByLine;
		private CBool _movementDodgeEnabled;
		private CString _additiveCameraGroupName;
		private CString _fastForwardGroupName;
		private CString _movementDodgeGroupName;
		private CString _difficultyPath;
		private CString _miscPath;
		private CString _controlsPath;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
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
		[RED("additiveCameraMovements")] 
		public CFloat AdditiveCameraMovements
		{
			get => GetProperty(ref _additiveCameraMovements);
			set => SetProperty(ref _additiveCameraMovements, value);
		}

		[Ordinal(6)] 
		[RED("isFastForwardByLine")] 
		public CBool IsFastForwardByLine
		{
			get => GetProperty(ref _isFastForwardByLine);
			set => SetProperty(ref _isFastForwardByLine, value);
		}

		[Ordinal(7)] 
		[RED("movementDodgeEnabled")] 
		public CBool MovementDodgeEnabled
		{
			get => GetProperty(ref _movementDodgeEnabled);
			set => SetProperty(ref _movementDodgeEnabled, value);
		}

		[Ordinal(8)] 
		[RED("additiveCameraGroupName")] 
		public CString AdditiveCameraGroupName
		{
			get => GetProperty(ref _additiveCameraGroupName);
			set => SetProperty(ref _additiveCameraGroupName, value);
		}

		[Ordinal(9)] 
		[RED("fastForwardGroupName")] 
		public CString FastForwardGroupName
		{
			get => GetProperty(ref _fastForwardGroupName);
			set => SetProperty(ref _fastForwardGroupName, value);
		}

		[Ordinal(10)] 
		[RED("movementDodgeGroupName")] 
		public CString MovementDodgeGroupName
		{
			get => GetProperty(ref _movementDodgeGroupName);
			set => SetProperty(ref _movementDodgeGroupName, value);
		}

		[Ordinal(11)] 
		[RED("difficultyPath")] 
		public CString DifficultyPath
		{
			get => GetProperty(ref _difficultyPath);
			set => SetProperty(ref _difficultyPath, value);
		}

		[Ordinal(12)] 
		[RED("miscPath")] 
		public CString MiscPath
		{
			get => GetProperty(ref _miscPath);
			set => SetProperty(ref _miscPath, value);
		}

		[Ordinal(13)] 
		[RED("controlsPath")] 
		public CString ControlsPath
		{
			get => GetProperty(ref _controlsPath);
			set => SetProperty(ref _controlsPath, value);
		}

		public GameplaySettingsListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
