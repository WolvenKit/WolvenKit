using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SoundSystemSettings : RedBaseClass
	{
		private TweakDBID _interactionName;
		private CHandle<MusicSettings> _musicSettings;
		private CBool _canBeUsedAsQuickHack;

		[Ordinal(0)] 
		[RED("interactionName")] 
		public TweakDBID InteractionName
		{
			get => GetProperty(ref _interactionName);
			set => SetProperty(ref _interactionName, value);
		}

		[Ordinal(1)] 
		[RED("musicSettings")] 
		public CHandle<MusicSettings> MusicSettings
		{
			get => GetProperty(ref _musicSettings);
			set => SetProperty(ref _musicSettings, value);
		}

		[Ordinal(2)] 
		[RED("canBeUsedAsQuickHack")] 
		public CBool CanBeUsedAsQuickHack
		{
			get => GetProperty(ref _canBeUsedAsQuickHack);
			set => SetProperty(ref _canBeUsedAsQuickHack, value);
		}
	}
}
