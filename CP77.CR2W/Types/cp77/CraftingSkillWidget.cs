using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CraftingSkillWidget : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("amountText")] public inkTextWidgetReference AmountText { get; set; }
		[Ordinal(3)] [RED("expFill")] public inkWidgetReference ExpFill { get; set; }
		[Ordinal(4)] [RED("perkHolder")] public inkWidgetReference PerkHolder { get; set; }
		[Ordinal(5)] [RED("levelUpAnimation")] public inkWidgetReference LevelUpAnimation { get; set; }
		[Ordinal(6)] [RED("expAnimation")] public inkWidgetReference ExpAnimation { get; set; }
		[Ordinal(7)] [RED("nextLevelText")] public inkTextWidgetReference NextLevelText { get; set; }
		[Ordinal(8)] [RED("expPointText1")] public inkTextWidgetReference ExpPointText1 { get; set; }
		[Ordinal(9)] [RED("expPointText2")] public inkTextWidgetReference ExpPointText2 { get; set; }
		[Ordinal(10)] [RED("levelUpBlackboard")] public CHandle<gameIBlackboard> LevelUpBlackboard { get; set; }
		[Ordinal(11)] [RED("playerLevelUpListener")] public CUInt32 PlayerLevelUpListener { get; set; }
		[Ordinal(12)] [RED("isLevelUp")] public CBool IsLevelUp { get; set; }
		[Ordinal(13)] [RED("currentExp")] public CInt32 CurrentExp { get; set; }

		public CraftingSkillWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
