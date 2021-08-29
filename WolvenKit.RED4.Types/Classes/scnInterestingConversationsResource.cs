using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnInterestingConversationsResource : CResource
	{
		private CArray<CHandle<scnInterestingConversationsGroup>> _conversationGroups;

		[Ordinal(1)] 
		[RED("conversationGroups")] 
		public CArray<CHandle<scnInterestingConversationsGroup>> ConversationGroups
		{
			get => GetProperty(ref _conversationGroups);
			set => SetProperty(ref _conversationGroups, value);
		}
	}
}
