using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DropPointControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(0)]  [RED("hasPlayerCollectedReward")] public CBool HasPlayerCollectedReward { get; set; }
		[Ordinal(1)]  [RED("rewardsLootTable")] public CArray<TweakDBID> RewardsLootTable { get; set; }
		[Ordinal(2)]  [RED("vendorRecord")] public CString VendorRecord { get; set; }

		public DropPointControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
