using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterestingConversationsResource : CResource
	{
		[Ordinal(1)] [RED("conversationGroups")] public CArray<CHandle<scnInterestingConversationsGroup>> ConversationGroups { get; set; }

		public scnInterestingConversationsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
