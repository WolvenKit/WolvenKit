using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnInterestingConversationsGroup : ISerializable
	{
		[Ordinal(0)] [RED("condition")] public CHandle<questIBaseCondition> Condition { get; set; }
		[Ordinal(1)] [RED("conversations")] public CArray<CHandle<scnInterestingConversationData>> Conversations { get; set; }

		public scnInterestingConversationsGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
