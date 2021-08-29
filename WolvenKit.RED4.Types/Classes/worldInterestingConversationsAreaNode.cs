using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInterestingConversationsAreaNode : worldTriggerAreaNode
	{
		private CArray<CResourceReference<scnInterestingConversationsResource>> _conversationGroups;
		private CArray<CHandle<worldConversationGroupData>> _conversationResources;
		private CArray<CHandle<worldConversationData>> _conversations;
		private CArray<NodeRef> _workspots;
		private CEnum<audioConversationSavingStrategy> _savingStrategy;

		[Ordinal(7)] 
		[RED("conversationGroups")] 
		public CArray<CResourceReference<scnInterestingConversationsResource>> ConversationGroups
		{
			get => GetProperty(ref _conversationGroups);
			set => SetProperty(ref _conversationGroups, value);
		}

		[Ordinal(8)] 
		[RED("conversationResources")] 
		public CArray<CHandle<worldConversationGroupData>> ConversationResources
		{
			get => GetProperty(ref _conversationResources);
			set => SetProperty(ref _conversationResources, value);
		}

		[Ordinal(9)] 
		[RED("conversations")] 
		public CArray<CHandle<worldConversationData>> Conversations
		{
			get => GetProperty(ref _conversations);
			set => SetProperty(ref _conversations, value);
		}

		[Ordinal(10)] 
		[RED("workspots")] 
		public CArray<NodeRef> Workspots
		{
			get => GetProperty(ref _workspots);
			set => SetProperty(ref _workspots, value);
		}

		[Ordinal(11)] 
		[RED("savingStrategy")] 
		public CEnum<audioConversationSavingStrategy> SavingStrategy
		{
			get => GetProperty(ref _savingStrategy);
			set => SetProperty(ref _savingStrategy, value);
		}
	}
}
