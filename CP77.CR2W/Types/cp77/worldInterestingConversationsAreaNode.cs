using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldInterestingConversationsAreaNode : worldTriggerAreaNode
	{
		[Ordinal(0)]  [RED("conversationGroups")] public CArray<rRef<scnInterestingConversationsResource>> ConversationGroups { get; set; }
		[Ordinal(1)]  [RED("conversationResources")] public CArray<CHandle<worldConversationGroupData>> ConversationResources { get; set; }
		[Ordinal(2)]  [RED("conversations")] public CArray<CHandle<worldConversationData>> Conversations { get; set; }
		[Ordinal(3)]  [RED("savingStrategy")] public CEnum<audioConversationSavingStrategy> SavingStrategy { get; set; }
		[Ordinal(4)]  [RED("workspots")] public CArray<NodeRef> Workspots { get; set; }

		public worldInterestingConversationsAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
