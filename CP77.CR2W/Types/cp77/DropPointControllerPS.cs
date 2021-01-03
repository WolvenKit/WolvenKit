using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
