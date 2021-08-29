using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAudioAttractAreaNode : worldTriggerAreaNode
	{
		private NodeRef _interestingConversationsNodeRef;
		private CArray<worldAudioAttractAreaNodeSettings> _audioAttractSoundSettings;

		[Ordinal(7)] 
		[RED("interestingConversationsNodeRef")] 
		public NodeRef InterestingConversationsNodeRef
		{
			get => GetProperty(ref _interestingConversationsNodeRef);
			set => SetProperty(ref _interestingConversationsNodeRef, value);
		}

		[Ordinal(8)] 
		[RED("audioAttractSoundSettings")] 
		public CArray<worldAudioAttractAreaNodeSettings> AudioAttractSoundSettings
		{
			get => GetProperty(ref _audioAttractSoundSettings);
			set => SetProperty(ref _audioAttractSoundSettings, value);
		}
	}
}
