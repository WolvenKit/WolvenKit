using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldConversationGroupData : ISerializable
	{
		[Ordinal(0)] 
		[RED("conversationGroup")] 
		public CResourceReference<scnInterestingConversationsResource> ConversationGroup
		{
			get => GetPropertyValue<CResourceReference<scnInterestingConversationsResource>>();
			set => SetPropertyValue<CResourceReference<scnInterestingConversationsResource>>(value);
		}

		[Ordinal(1)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetPropertyValue<CArray<CHandle<scnIInterruptionOperation>>>();
			set => SetPropertyValue<CArray<CHandle<scnIInterruptionOperation>>>(value);
		}

		[Ordinal(2)] 
		[RED("ignoreLocalLimit")] 
		public CBool IgnoreLocalLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("ignoreGlobalLimit")] 
		public CBool IgnoreGlobalLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldConversationGroupData()
		{
			InterruptionOperations = new() { null, null };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
