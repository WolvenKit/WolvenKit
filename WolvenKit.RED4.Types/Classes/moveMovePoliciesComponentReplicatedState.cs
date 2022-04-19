using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class moveMovePoliciesComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] 
		[RED("movePolicies")] 
		public moveReplicatedMovePoliciesState MovePolicies
		{
			get => GetPropertyValue<moveReplicatedMovePoliciesState>();
			set => SetPropertyValue<moveReplicatedMovePoliciesState>(value);
		}

		public moveMovePoliciesComponentReplicatedState()
		{
			Enabled = true;
			MovePolicies = new() { Items = new(), LastAppliedActionsTime = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
