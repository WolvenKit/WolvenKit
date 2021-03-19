using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterestingConversationsResource : CResource
	{
		private CArray<CHandle<scnInterestingConversationsGroup>> _conversationGroups;

		[Ordinal(1)] 
		[RED("conversationGroups")] 
		public CArray<CHandle<scnInterestingConversationsGroup>> ConversationGroups
		{
			get => GetProperty(ref _conversationGroups);
			set => SetProperty(ref _conversationGroups, value);
		}

		public scnInterestingConversationsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
