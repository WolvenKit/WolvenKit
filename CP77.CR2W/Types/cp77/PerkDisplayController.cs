using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayController : inkButtonController
	{
		[Ordinal(0)]  [RED("levelText")] public inkTextWidgetReference LevelText { get; set; }
		[Ordinal(1)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(2)]  [RED("fluffText")] public inkTextWidgetReference FluffText { get; set; }
		[Ordinal(3)]  [RED("requiredTrainerIcon")] public inkWidgetReference RequiredTrainerIcon { get; set; }
		[Ordinal(4)]  [RED("requiredPointsText")] public inkTextWidgetReference RequiredPointsText { get; set; }
		[Ordinal(5)]  [RED("displayData")] public CHandle<BasePerkDisplayData> DisplayData { get; set; }
		[Ordinal(6)]  [RED("dataManager")] public CHandle<PlayerDevelopmentDataManager> DataManager { get; set; }
		[Ordinal(7)]  [RED("playerDevelopmentData")] public wCHandle<PlayerDevelopmentData> PlayerDevelopmentData { get; set; }
		[Ordinal(8)]  [RED("recentlyPurchased")] public CBool RecentlyPurchased { get; set; }
		[Ordinal(9)]  [RED("holdStarted")] public CBool HoldStarted { get; set; }
		[Ordinal(10)]  [RED("isTrait")] public CBool IsTrait { get; set; }
		[Ordinal(11)]  [RED("wasLocked")] public CBool WasLocked { get; set; }
		[Ordinal(12)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(13)]  [RED("cool_in_proxy")] public CHandle<inkanimProxy> Cool_in_proxy { get; set; }
		[Ordinal(14)]  [RED("cool_out_proxy")] public CHandle<inkanimProxy> Cool_out_proxy { get; set; }

		public PerkDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
