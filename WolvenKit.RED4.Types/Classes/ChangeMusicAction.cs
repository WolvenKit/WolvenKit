using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeMusicAction : ActionBool
	{
		private CString _interactionRecordName;
		private CHandle<MusicSettings> _settings;

		[Ordinal(25)] 
		[RED("interactionRecordName")] 
		public CString InteractionRecordName
		{
			get => GetProperty(ref _interactionRecordName);
			set => SetProperty(ref _interactionRecordName, value);
		}

		[Ordinal(26)] 
		[RED("settings")] 
		public CHandle<MusicSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}
	}
}
