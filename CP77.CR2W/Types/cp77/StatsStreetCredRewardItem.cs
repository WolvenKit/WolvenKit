using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatsStreetCredRewardItem : inkButtonController
	{
		[Ordinal(0)]  [RED("levelRef")] public inkTextWidgetReference LevelRef { get; set; }
		[Ordinal(1)]  [RED("iconRef")] public inkImageWidgetReference IconRef { get; set; }
		[Ordinal(2)]  [RED("data")] public CHandle<LevelRewardDisplayData> Data { get; set; }

		public StatsStreetCredRewardItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
