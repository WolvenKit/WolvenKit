using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFSMStateDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("onUpdateTransition")] 
		public AIFSMTransitionListDefinition OnUpdateTransition
		{
			get => GetPropertyValue<AIFSMTransitionListDefinition>();
			set => SetPropertyValue<AIFSMTransitionListDefinition>(value);
		}

		[Ordinal(1)] 
		[RED("onCompleteTransition")] 
		public AIFSMTransitionListDefinition OnCompleteTransition
		{
			get => GetPropertyValue<AIFSMTransitionListDefinition>();
			set => SetPropertyValue<AIFSMTransitionListDefinition>(value);
		}

		[Ordinal(2)] 
		[RED("onSuccessTransition")] 
		public AIFSMTransitionListDefinition OnSuccessTransition
		{
			get => GetPropertyValue<AIFSMTransitionListDefinition>();
			set => SetPropertyValue<AIFSMTransitionListDefinition>(value);
		}

		[Ordinal(3)] 
		[RED("onFailureTransition")] 
		public AIFSMTransitionListDefinition OnFailureTransition
		{
			get => GetPropertyValue<AIFSMTransitionListDefinition>();
			set => SetPropertyValue<AIFSMTransitionListDefinition>(value);
		}

		[Ordinal(4)] 
		[RED("onInterruptionTransition")] 
		public AIFSMTransitionListDefinition OnInterruptionTransition
		{
			get => GetPropertyValue<AIFSMTransitionListDefinition>();
			set => SetPropertyValue<AIFSMTransitionListDefinition>(value);
		}

		[Ordinal(5)] 
		[RED("onEventTransitions")] 
		public AIFSMTransitionListDefinition OnEventTransitions
		{
			get => GetPropertyValue<AIFSMTransitionListDefinition>();
			set => SetPropertyValue<AIFSMTransitionListDefinition>(value);
		}

		[Ordinal(6)] 
		[RED("childNode")] 
		public CHandle<AICTreeNodeDefinition> ChildNode
		{
			get => GetPropertyValue<CHandle<AICTreeNodeDefinition>>();
			set => SetPropertyValue<CHandle<AICTreeNodeDefinition>>(value);
		}

		public AIFSMStateDefinition()
		{
			OnUpdateTransition = new AIFSMTransitionListDefinition();
			OnCompleteTransition = new AIFSMTransitionListDefinition();
			OnSuccessTransition = new AIFSMTransitionListDefinition();
			OnFailureTransition = new AIFSMTransitionListDefinition();
			OnInterruptionTransition = new AIFSMTransitionListDefinition();
			OnEventTransitions = new AIFSMTransitionListDefinition();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
