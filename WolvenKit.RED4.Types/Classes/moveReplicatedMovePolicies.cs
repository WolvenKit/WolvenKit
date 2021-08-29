using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveReplicatedMovePolicies : entReplicatedItem
	{
		private CUInt64 _key;
		private CHandle<movePolicies> _policies;

		[Ordinal(2)] 
		[RED("key")] 
		public CUInt64 Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(3)] 
		[RED("policies")] 
		public CHandle<movePolicies> Policies
		{
			get => GetProperty(ref _policies);
			set => SetProperty(ref _policies, value);
		}
	}
}
