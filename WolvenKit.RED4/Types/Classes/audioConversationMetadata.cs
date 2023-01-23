using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioConversationMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("conversations")] 
		public CArray<audioConversationItemMetadata> Conversations
		{
			get => GetPropertyValue<CArray<audioConversationItemMetadata>>();
			set => SetPropertyValue<CArray<audioConversationItemMetadata>>(value);
		}

		public audioConversationMetadata()
		{
			Conversations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
