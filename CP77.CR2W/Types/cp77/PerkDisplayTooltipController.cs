using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayTooltipController : AGenericTooltipController
	{
		[Ordinal(2)] [RED("root")] public inkWidgetReference Root_16 { get; set; }
		[Ordinal(3)] [RED("perkNameText")] public inkTextWidgetReference PerkNameText { get; set; }
		[Ordinal(4)] [RED("videoWrapper")] public inkWidgetReference VideoWrapper { get; set; }
		[Ordinal(5)] [RED("videoWidget")] public inkVideoWidgetReference VideoWidget { get; set; }
		[Ordinal(6)] [RED("unlockStateText")] public inkTextWidgetReference UnlockStateText { get; set; }
		[Ordinal(7)] [RED("perkTypeText")] public inkTextWidgetReference PerkTypeText { get; set; }
		[Ordinal(8)] [RED("perkTypeWrapper")] public inkWidgetReference PerkTypeWrapper { get; set; }
		[Ordinal(9)] [RED("unlockInfoWrapper")] public inkWidgetReference UnlockInfoWrapper { get; set; }
		[Ordinal(10)] [RED("unlockPointsText")] public inkTextWidgetReference UnlockPointsText { get; set; }
		[Ordinal(11)] [RED("unlockPointsDesc")] public inkTextWidgetReference UnlockPointsDesc { get; set; }
		[Ordinal(12)] [RED("unlockPerkWrapper")] public inkWidgetReference UnlockPerkWrapper { get; set; }
		[Ordinal(13)] [RED("levelText")] public inkTextWidgetReference LevelText { get; set; }
		[Ordinal(14)] [RED("levelDescriptionText")] public inkTextWidgetReference LevelDescriptionText { get; set; }
		[Ordinal(15)] [RED("nextLevelWrapper")] public inkWidgetReference NextLevelWrapper { get; set; }
		[Ordinal(16)] [RED("nextLevelText")] public inkTextWidgetReference NextLevelText { get; set; }
		[Ordinal(17)] [RED("nextLevelDescriptionText")] public inkTextWidgetReference NextLevelDescriptionText { get; set; }
		[Ordinal(18)] [RED("traitLevelGrowthText")] public inkTextWidgetReference TraitLevelGrowthText { get; set; }
		[Ordinal(19)] [RED("unlockTraitPointsText")] public inkTextWidgetReference UnlockTraitPointsText { get; set; }
		[Ordinal(20)] [RED("unlockTraitWrapper")] public inkWidgetReference UnlockTraitWrapper { get; set; }
		[Ordinal(21)] [RED("holdToUpgradeHint")] public inkWidgetReference HoldToUpgradeHint { get; set; }
		[Ordinal(22)] [RED("data")] public CHandle<BasePerksMenuTooltipData> Data { get; set; }

		public PerkDisplayTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
