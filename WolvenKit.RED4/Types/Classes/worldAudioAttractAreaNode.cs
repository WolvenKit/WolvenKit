using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAudioAttractAreaNode : worldTriggerAreaNode
	{
		[Ordinal(5)] 
		[RED("interestingConversationsNodeRef")] 
		public NodeRef InterestingConversationsNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(6)] 
		[RED("audioAttractSoundSettings")] 
		public CArray<worldAudioAttractAreaNodeSettings> AudioAttractSoundSettings
		{
			get => GetPropertyValue<CArray<worldAudioAttractAreaNodeSettings>>();
			set => SetPropertyValue<CArray<worldAudioAttractAreaNodeSettings>>(value);
		}

		public worldAudioAttractAreaNode()
		{
			Color = new CColor { Red = 127, Green = 255, Blue = 127, Alpha = 255 };
			AudioAttractSoundSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
