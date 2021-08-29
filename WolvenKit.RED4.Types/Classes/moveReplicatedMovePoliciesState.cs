using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveReplicatedMovePoliciesState : RedBaseClass
	{
		private CArray<moveReplicatedMovePolicies> _items;
		private netTime _lastAppliedActionsTime;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<moveReplicatedMovePolicies> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		[Ordinal(1)] 
		[RED("lastAppliedActionsTime")] 
		public netTime LastAppliedActionsTime
		{
			get => GetProperty(ref _lastAppliedActionsTime);
			set => SetProperty(ref _lastAppliedActionsTime, value);
		}
	}
}
