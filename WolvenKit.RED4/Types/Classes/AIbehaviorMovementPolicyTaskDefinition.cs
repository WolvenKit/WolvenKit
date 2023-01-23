using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorMovementPolicyTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("useCurrentPolicy")] 
		public CBool UseCurrentPolicy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("waitForPolicy")] 
		public CBool WaitForPolicy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("stopWhenDestinationReached")] 
		public CHandle<AIArgumentMapping> StopWhenDestinationReached
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("policies")] 
		public CArray<CHandle<AIbehaviorMovementPolicyTaskItemDefinition>> Policies
		{
			get => GetPropertyValue<CArray<CHandle<AIbehaviorMovementPolicyTaskItemDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<AIbehaviorMovementPolicyTaskItemDefinition>>>(value);
		}

		public AIbehaviorMovementPolicyTaskDefinition()
		{
			WaitForPolicy = true;
			Policies = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
