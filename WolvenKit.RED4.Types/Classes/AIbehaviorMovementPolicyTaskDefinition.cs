using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorMovementPolicyTaskDefinition : AIbehaviorTaskDefinition
	{
		private CBool _useCurrentPolicy;
		private CBool _waitForPolicy;
		private CHandle<AIArgumentMapping> _stopWhenDestinationReached;
		private CArray<CHandle<AIbehaviorMovementPolicyTaskItemDefinition>> _policies;

		[Ordinal(1)] 
		[RED("useCurrentPolicy")] 
		public CBool UseCurrentPolicy
		{
			get => GetProperty(ref _useCurrentPolicy);
			set => SetProperty(ref _useCurrentPolicy, value);
		}

		[Ordinal(2)] 
		[RED("waitForPolicy")] 
		public CBool WaitForPolicy
		{
			get => GetProperty(ref _waitForPolicy);
			set => SetProperty(ref _waitForPolicy, value);
		}

		[Ordinal(3)] 
		[RED("stopWhenDestinationReached")] 
		public CHandle<AIArgumentMapping> StopWhenDestinationReached
		{
			get => GetProperty(ref _stopWhenDestinationReached);
			set => SetProperty(ref _stopWhenDestinationReached, value);
		}

		[Ordinal(4)] 
		[RED("policies")] 
		public CArray<CHandle<AIbehaviorMovementPolicyTaskItemDefinition>> Policies
		{
			get => GetProperty(ref _policies);
			set => SetProperty(ref _policies, value);
		}
	}
}
