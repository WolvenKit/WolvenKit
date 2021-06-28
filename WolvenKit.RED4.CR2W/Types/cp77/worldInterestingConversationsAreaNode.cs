using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldInterestingConversationsAreaNode : worldTriggerAreaNode
	{
		private CArray<rRef<scnInterestingConversationsResource>> _conversationGroups;
		private CArray<CHandle<worldConversationGroupData>> _conversationResources;
		private CArray<CHandle<worldConversationData>> _conversations;
		private CArray<NodeRef> _workspots;
		private CEnum<audioConversationSavingStrategy> _savingStrategy;

		[Ordinal(7)] 
		[RED("conversationGroups")] 
		public CArray<rRef<scnInterestingConversationsResource>> ConversationGroups
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

		public worldInterestingConversationsAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
