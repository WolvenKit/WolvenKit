using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldInterestingConversationsAreaNode : worldTriggerAreaNode
	{
		[Ordinal(7)] [RED("conversationGroups")] public CArray<rRef<scnInterestingConversationsResource>> ConversationGroups { get; set; }
		[Ordinal(8)] [RED("conversationResources")] public CArray<CHandle<worldConversationGroupData>> ConversationResources { get; set; }
		[Ordinal(9)] [RED("conversations")] public CArray<CHandle<worldConversationData>> Conversations { get; set; }
		[Ordinal(10)] [RED("workspots")] public CArray<NodeRef> Workspots { get; set; }
		[Ordinal(11)] [RED("savingStrategy")] public CEnum<audioConversationSavingStrategy> SavingStrategy { get; set; }

		public worldInterestingConversationsAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
