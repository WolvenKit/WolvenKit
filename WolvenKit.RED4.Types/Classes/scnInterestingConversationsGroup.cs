using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnInterestingConversationsGroup : ISerializable
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
	}
}
