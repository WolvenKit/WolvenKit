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
			get
			{
				if (_conversationGroups == null)
				{
					_conversationGroups = (CArray<CHandle<scnInterestingConversationsGroup>>) CR2WTypeManager.Create("array:handle:scnInterestingConversationsGroup", "conversationGroups", cr2w, this);
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

		public scnInterestingConversationsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
