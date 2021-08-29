using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPointControllerPS : BasicDistractionDeviceControllerPS
	{
		private CString _vendorRecord;
		private CArray<TweakDBID> _rewardsLootTable;
		private CBool _hasPlayerCollectedReward;

		[Ordinal(109)] 
		[RED("vendorRecord")] 
		public CString VendorRecord
		{
			get => GetProperty(ref _vendorRecord);
			set => SetProperty(ref _vendorRecord, value);
		}

		[Ordinal(110)] 
		[RED("rewardsLootTable")] 
		public CArray<TweakDBID> RewardsLootTable
		{
			get => GetProperty(ref _rewardsLootTable);
			set => SetProperty(ref _rewardsLootTable, value);
		}

		[Ordinal(111)] 
		[RED("hasPlayerCollectedReward")] 
		public CBool HasPlayerCollectedReward
		{
			get => GetProperty(ref _hasPlayerCollectedReward);
			set => SetProperty(ref _hasPlayerCollectedReward, value);
		}
	}
}
