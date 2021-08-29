using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioConversationMetadata : audioAudioMetadata
	{
		private CArray<audioConversationItemMetadata> _conversations;

		[Ordinal(1)] 
		[RED("conversations")] 
		public CArray<audioConversationItemMetadata> Conversations
		{
			get => GetProperty(ref _conversations);
			set => SetProperty(ref _conversations, value);
		}
	}
}
