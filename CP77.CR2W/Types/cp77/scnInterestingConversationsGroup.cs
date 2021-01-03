using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnInterestingConversationsGroup : ISerializable
	{
		[Ordinal(0)]  [RED("condition")] public CHandle<questIBaseCondition> Condition { get; set; }
		[Ordinal(1)]  [RED("conversations")] public CArray<CHandle<scnInterestingConversationData>> Conversations { get; set; }

		public scnInterestingConversationsGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
