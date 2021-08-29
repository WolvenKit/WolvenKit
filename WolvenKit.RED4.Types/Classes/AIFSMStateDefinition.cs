using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFSMStateDefinition : RedBaseClass
	{
		private AIFSMTransitionListDefinition _onUpdateTransition;
		private AIFSMTransitionListDefinition _onCompleteTransition;
		private AIFSMTransitionListDefinition _onSuccessTransition;
		private AIFSMTransitionListDefinition _onFailureTransition;
		private AIFSMTransitionListDefinition _onInterruptionTransition;
		private AIFSMTransitionListDefinition _onEventTransitions;
		private CHandle<AICTreeNodeDefinition> _childNode;

		[Ordinal(0)] 
		[RED("onUpdateTransition")] 
		public AIFSMTransitionListDefinition OnUpdateTransition
		{
			get => GetProperty(ref _onUpdateTransition);
			set => SetProperty(ref _onUpdateTransition, value);
		}

		[Ordinal(1)] 
		[RED("onCompleteTransition")] 
		public AIFSMTransitionListDefinition OnCompleteTransition
		{
			get => GetProperty(ref _onCompleteTransition);
			set => SetProperty(ref _onCompleteTransition, value);
		}

		[Ordinal(2)] 
		[RED("onSuccessTransition")] 
		public AIFSMTransitionListDefinition OnSuccessTransition
		{
			get => GetProperty(ref _onSuccessTransition);
			set => SetProperty(ref _onSuccessTransition, value);
		}

		[Ordinal(3)] 
		[RED("onFailureTransition")] 
		public AIFSMTransitionListDefinition OnFailureTransition
		{
			get => GetProperty(ref _onFailureTransition);
			set => SetProperty(ref _onFailureTransition, value);
		}

		[Ordinal(4)] 
		[RED("onInterruptionTransition")] 
		public AIFSMTransitionListDefinition OnInterruptionTransition
		{
			get => GetProperty(ref _onInterruptionTransition);
			set => SetProperty(ref _onInterruptionTransition, value);
		}

		[Ordinal(5)] 
		[RED("onEventTransitions")] 
		public AIFSMTransitionListDefinition OnEventTransitions
		{
			get => GetProperty(ref _onEventTransitions);
			set => SetProperty(ref _onEventTransitions, value);
		}

		[Ordinal(6)] 
		[RED("childNode")] 
		public CHandle<AICTreeNodeDefinition> ChildNode
		{
			get => GetProperty(ref _childNode);
			set => SetProperty(ref _childNode, value);
		}
	}
}
