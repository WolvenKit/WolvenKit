using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropPointControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(113)] 
		[RED("vendorRecord")] 
		public CString VendorRecord
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(114)] 
		[RED("rewardsLootTable")] 
		public CArray<TweakDBID> RewardsLootTable
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(115)] 
		[RED("hasPlayerCollectedReward")] 
		public CBool HasPlayerCollectedReward
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DropPointControllerPS()
		{
			RewardsLootTable = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
