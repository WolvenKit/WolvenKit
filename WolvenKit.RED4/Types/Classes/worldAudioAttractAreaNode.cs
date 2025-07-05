using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAudioAttractAreaNode : worldTriggerAreaNode
	{
		[Ordinal(7)] 
		[RED("interestingConversationsNodeRef")] 
		public NodeRef InterestingConversationsNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(8)] 
		[RED("audioAttractSoundSettings")] 
		public CArray<worldAudioAttractAreaNodeSettings> AudioAttractSoundSettings
		{
			get => GetPropertyValue<CArray<worldAudioAttractAreaNodeSettings>>();
			set => SetPropertyValue<CArray<worldAudioAttractAreaNodeSettings>>(value);
		}

		public worldAudioAttractAreaNode()
		{
			AudioAttractSoundSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
