using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveMovePoliciesComponentReplicatedState : netIComponentState
	{
		private moveReplicatedMovePoliciesState _movePolicies;

		[Ordinal(2)] 
		[RED("movePolicies")] 
		public moveReplicatedMovePoliciesState MovePolicies
		{
			get => GetProperty(ref _movePolicies);
			set => SetProperty(ref _movePolicies, value);
		}
	}
}
