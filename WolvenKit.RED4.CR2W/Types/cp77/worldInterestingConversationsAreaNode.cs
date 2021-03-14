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
			get
			{
				if (_conversationGroups == null)
				{
					_conversationGroups = (CArray<rRef<scnInterestingConversationsResource>>) CR2WTypeManager.Create("array:rRef:scnInterestingConversationsResource", "conversationGroups", cr2w, this);
				}
				return _conversationGroups;
			}
			set
			{
				if (_conversationGroups == value)
				{
					return;
				}
				_conversationGroups = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("conversationResources")] 
		public CArray<CHandle<worldConversationGroupData>> ConversationResources
		{
			get
			{
				if (_conversationResources == null)
				{
					_conversationResources = (CArray<CHandle<worldConversationGroupData>>) CR2WTypeManager.Create("array:handle:worldConversationGroupData", "conversationResources", cr2w, this);
				}
				return _conversationResources;
			}
			set
			{
				if (_conversationResources == value)
				{
					return;
				}
				_conversationResources = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("conversations")] 
		public CArray<CHandle<worldConversationData>> Conversations
		{
			get
			{
				if (_conversations == null)
				{
					_conversations = (CArray<CHandle<worldConversationData>>) CR2WTypeManager.Create("array:handle:worldConversationData", "conversations", cr2w, this);
				}
				return _conversations;
			}
			set
			{
				if (_conversations == value)
				{
					return;
				}
				_conversations = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("workspots")] 
		public CArray<NodeRef> Workspots
		{
			get
			{
				if (_workspots == null)
				{
					_workspots = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "workspots", cr2w, this);
				}
				return _workspots;
			}
			set
			{
				if (_workspots == value)
				{
					return;
				}
				_workspots = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("savingStrategy")] 
		public CEnum<audioConversationSavingStrategy> SavingStrategy
		{
			get
			{
				if (_savingStrategy == null)
				{
					_savingStrategy = (CEnum<audioConversationSavingStrategy>) CR2WTypeManager.Create("audioConversationSavingStrategy", "savingStrategy", cr2w, this);
				}
				return _savingStrategy;
			}
			set
			{
				if (_savingStrategy == value)
				{
					return;
				}
				_savingStrategy = value;
				PropertySet(this);
			}
		}

		public worldInterestingConversationsAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
