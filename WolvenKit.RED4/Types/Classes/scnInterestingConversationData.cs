using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnInterestingConversationData : ISerializable
	{
		[Ordinal(0)] 
		[RED("sceneFilename")] 
		public CResourceAsyncReference<scnSceneResource> SceneFilename
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		[Ordinal(1)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetPropertyValue<CArray<CHandle<scnIInterruptionOperation>>>();
			set => SetPropertyValue<CArray<CHandle<scnIInterruptionOperation>>>(value);
		}

		public scnInterestingConversationData()
		{
			InterruptionOperations = new() { new scnToggleInterruption_InterruptionOperation(), new scnOverrideInterruptionScenario_InterruptionOperation { ScenarioId = new scnInterruptionScenarioId { Id = 0 }, ScenarioOperations = new() { new scnOverrideTalkOnReturn_InterruptionScenarioOperation { TalkOnReturn = false }, new scnOverrideInterruptConditions_InterruptionScenarioOperation { InterruptConditions = new() { new scnCheckAnyoneDistractedInterruptCondition() } }, new scnOverrideReturnConditions_InterruptionScenarioOperation { ReturnConditions = new() { new scnCheckDistractedReturnCondition() } } } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
