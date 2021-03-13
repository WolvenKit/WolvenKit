using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayController : inkButtonController
	{
		[Ordinal(10)] [RED("levelText")] public inkTextWidgetReference LevelText { get; set; }
		[Ordinal(11)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(12)] [RED("fluffText")] public inkTextWidgetReference FluffText { get; set; }
		[Ordinal(13)] [RED("requiredTrainerIcon")] public inkWidgetReference RequiredTrainerIcon { get; set; }
		[Ordinal(14)] [RED("requiredPointsText")] public inkTextWidgetReference RequiredPointsText { get; set; }
		[Ordinal(15)] [RED("displayData")] public CHandle<BasePerkDisplayData> DisplayData { get; set; }
		[Ordinal(16)] [RED("dataManager")] public CHandle<PlayerDevelopmentDataManager> DataManager { get; set; }
		[Ordinal(17)] [RED("playerDevelopmentData")] public wCHandle<PlayerDevelopmentData> PlayerDevelopmentData { get; set; }
		[Ordinal(18)] [RED("recentlyPurchased")] public CBool RecentlyPurchased { get; set; }
		[Ordinal(19)] [RED("holdStarted")] public CBool HoldStarted { get; set; }
		[Ordinal(20)] [RED("isTrait")] public CBool IsTrait { get; set; }
		[Ordinal(21)] [RED("wasLocked")] public CBool WasLocked { get; set; }
		[Ordinal(22)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(23)] [RED("cool_in_proxy")] public CHandle<inkanimProxy> Cool_in_proxy { get; set; }
		[Ordinal(24)] [RED("cool_out_proxy")] public CHandle<inkanimProxy> Cool_out_proxy { get; set; }

		public PerkDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
