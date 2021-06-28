using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMovementPolicyTaskDefinition : AIbehaviorTaskDefinition
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

		public AIbehaviorMovementPolicyTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
