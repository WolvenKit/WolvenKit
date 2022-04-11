using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveReplicatedMovePoliciesState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("items")] 
		public CArray<moveReplicatedMovePolicies> Items
		{
			get => GetPropertyValue<CArray<moveReplicatedMovePolicies>>();
			set => SetPropertyValue<CArray<moveReplicatedMovePolicies>>(value);
		}

		[Ordinal(1)] 
		[RED("lastAppliedActionsTime")] 
		public netTime LastAppliedActionsTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public moveReplicatedMovePoliciesState()
		{
			Items = new();
			LastAppliedActionsTime = new();
		}
	}
}
