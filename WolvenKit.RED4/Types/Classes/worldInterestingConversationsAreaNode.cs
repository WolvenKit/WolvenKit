using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldInterestingConversationsAreaNode : worldTriggerAreaNode
	{
		[Ordinal(7)] 
		[RED("conversationGroups")] 
		public CArray<CResourceReference<scnInterestingConversationsResource>> ConversationGroups
		{
			get => GetPropertyValue<CArray<CResourceReference<scnInterestingConversationsResource>>>();
			set => SetPropertyValue<CArray<CResourceReference<scnInterestingConversationsResource>>>(value);
		}

		[Ordinal(8)] 
		[RED("conversationResources")] 
		public CArray<CHandle<worldConversationGroupData>> ConversationResources
		{
			get => GetPropertyValue<CArray<CHandle<worldConversationGroupData>>>();
			set => SetPropertyValue<CArray<CHandle<worldConversationGroupData>>>(value);
		}

		[Ordinal(9)] 
		[RED("conversations")] 
		public CArray<CHandle<worldConversationData>> Conversations
		{
			get => GetPropertyValue<CArray<CHandle<worldConversationData>>>();
			set => SetPropertyValue<CArray<CHandle<worldConversationData>>>(value);
		}

		[Ordinal(10)] 
		[RED("workspots")] 
		public CArray<NodeRef> Workspots
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(11)] 
		[RED("savingStrategy")] 
		public CEnum<audioConversationSavingStrategy> SavingStrategy
		{
			get => GetPropertyValue<CEnum<audioConversationSavingStrategy>>();
			set => SetPropertyValue<CEnum<audioConversationSavingStrategy>>(value);
		}

		public worldInterestingConversationsAreaNode()
		{
			ConversationGroups = new();
			ConversationResources = new();
			Conversations = new();
			Workspots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
