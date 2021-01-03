using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LevelRewardDisplayData : IDisplayData
	{
		[Ordinal(0)]  [RED("description")] public CString Description { get; set; }
		[Ordinal(1)]  [RED("icon")] public CName Icon { get; set; }
		[Ordinal(2)]  [RED("level")] public CInt32 Level { get; set; }
		[Ordinal(3)]  [RED("locPackage")] public CHandle<gameUILocalizationDataPackage> LocPackage { get; set; }
		[Ordinal(4)]  [RED("rewardName")] public CString RewardName { get; set; }

		public LevelRewardDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
