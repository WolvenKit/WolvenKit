using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointControllerPS : BasicDistractionDeviceControllerPS
	{
		private CString _vendorRecord;
		private CArray<TweakDBID> _rewardsLootTable;
		private CBool _hasPlayerCollectedReward;

		[Ordinal(108)] 
		[RED("vendorRecord")] 
		public CString VendorRecord
		{
			get => GetProperty(ref _vendorRecord);
			set => SetProperty(ref _vendorRecord, value);
		}

		[Ordinal(109)] 
		[RED("rewardsLootTable")] 
		public CArray<TweakDBID> RewardsLootTable
		{
			get => GetProperty(ref _rewardsLootTable);
			set => SetProperty(ref _rewardsLootTable, value);
		}

		[Ordinal(110)] 
		[RED("hasPlayerCollectedReward")] 
		public CBool HasPlayerCollectedReward
		{
			get => GetProperty(ref _hasPlayerCollectedReward);
			set => SetProperty(ref _hasPlayerCollectedReward, value);
		}

		public DropPointControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
