using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class moveReplicatedMovePolicies : entReplicatedItem
	{
		[Ordinal(2)] 
		[RED("key")] 
		public CUInt64 Key
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("policies")] 
		public CHandle<movePolicies> Policies
		{
			get => GetPropertyValue<CHandle<movePolicies>>();
			set => SetPropertyValue<CHandle<movePolicies>>(value);
		}

		public moveReplicatedMovePolicies()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
