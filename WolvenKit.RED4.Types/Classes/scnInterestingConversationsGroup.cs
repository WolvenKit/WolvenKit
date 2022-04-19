using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnInterestingConversationsGroup : ISerializable
	{
		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get => GetPropertyValue<CHandle<questIBaseCondition>>();
			set => SetPropertyValue<CHandle<questIBaseCondition>>(value);
		}

		[Ordinal(1)] 
		[RED("conversations")] 
		public CArray<CHandle<scnInterestingConversationData>> Conversations
		{
			get => GetPropertyValue<CArray<CHandle<scnInterestingConversationData>>>();
			set => SetPropertyValue<CArray<CHandle<scnInterestingConversationData>>>(value);
		}

		public scnInterestingConversationsGroup()
		{
			Conversations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
