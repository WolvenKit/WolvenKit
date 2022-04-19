using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorFSMStateDefinition : AIbehaviorTreeNodeDefinition
	{
		[Ordinal(0)] 
		[RED("behaviorRoot")] 
		public CHandle<AIbehaviorTreeNodeDefinition> BehaviorRoot
		{
			get => GetPropertyValue<CHandle<AIbehaviorTreeNodeDefinition>>();
			set => SetPropertyValue<CHandle<AIbehaviorTreeNodeDefinition>>(value);
		}

		[Ordinal(1)] 
		[RED("isInitial")] 
		public CBool IsInitial
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isExit")] 
		public CBool IsExit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("completionStatus")] 
		public CEnum<AIbehaviorStateCompletionStatus> CompletionStatus
		{
			get => GetPropertyValue<CEnum<AIbehaviorStateCompletionStatus>>();
			set => SetPropertyValue<CEnum<AIbehaviorStateCompletionStatus>>(value);
		}

		public AIbehaviorFSMStateDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
