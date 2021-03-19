using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterestingConversationsGroup : ISerializable
	{
		private CHandle<questIBaseCondition> _condition;
		private CArray<CHandle<scnInterestingConversationData>> _conversations;

		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(1)] 
		[RED("conversations")] 
		public CArray<CHandle<scnInterestingConversationData>> Conversations
		{
			get => GetProperty(ref _conversations);
			set => SetProperty(ref _conversations, value);
		}

		public scnInterestingConversationsGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
