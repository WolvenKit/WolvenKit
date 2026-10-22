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
			InterruptionOperations = new() { new scnToggleInterruption_InterruptionOperation(), new scnOverrideInterruptionScenario_InterruptionOperation { ScenarioId = new scnInterruptionScenarioId { Id = 0 }, ScenarioOperations = new() { new scnOverrideTalkOnReturn_InterruptionScenarioOperation { TalkOnReturn = false }, new scnOverrideInterruptConditions_InterruptionScenarioOperation { InterruptConditions = new() { new scnCheckAnyoneDistractedInterruptCondition() } }, new scnOverrideReturnConditions_InterruptionScenarioOperation { ReturnConditions = new() { new scnCheckDistractedReturnCondition() } } } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
