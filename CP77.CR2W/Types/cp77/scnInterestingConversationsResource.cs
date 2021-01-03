using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnInterestingConversationsResource : CResource
	{
		[Ordinal(0)]  [RED("conversationGroups")] public CArray<CHandle<scnInterestingConversationsGroup>> ConversationGroups { get; set; }

		public scnInterestingConversationsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
