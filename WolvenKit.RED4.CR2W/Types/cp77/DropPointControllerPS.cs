using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(108)] [RED("vendorRecord")] public CString VendorRecord { get; set; }
		[Ordinal(109)] [RED("rewardsLootTable")] public CArray<TweakDBID> RewardsLootTable { get; set; }
		[Ordinal(110)] [RED("hasPlayerCollectedReward")] public CBool HasPlayerCollectedReward { get; set; }

		public DropPointControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
