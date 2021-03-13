using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LevelRewardDisplayData : IDisplayData
	{
		[Ordinal(0)] [RED("level")] public CInt32 Level { get; set; }
		[Ordinal(1)] [RED("rewardName")] public CString RewardName { get; set; }
		[Ordinal(2)] [RED("description")] public CString Description { get; set; }
		[Ordinal(3)] [RED("icon")] public CName Icon { get; set; }
		[Ordinal(4)] [RED("locPackage")] public CHandle<gameUILocalizationDataPackage> LocPackage { get; set; }

		public LevelRewardDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
