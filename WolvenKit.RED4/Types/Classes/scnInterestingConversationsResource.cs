using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnInterestingConversationsResource : CResource
	{
		[Ordinal(1)] 
		[RED("conversationGroups")] 
		public CArray<CHandle<scnInterestingConversationsGroup>> ConversationGroups
		{
			get => GetPropertyValue<CArray<CHandle<scnInterestingConversationsGroup>>>();
			set => SetPropertyValue<CArray<CHandle<scnInterestingConversationsGroup>>>(value);
		}

		public scnInterestingConversationsResource()
		{
			ConversationGroups = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
