using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CraftingSkillWidget : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("amountText")] public inkTextWidgetReference AmountText { get; set; }
		[Ordinal(1)]  [RED("currentExp")] public CInt32 CurrentExp { get; set; }
		[Ordinal(2)]  [RED("expAnimation")] public inkWidgetReference ExpAnimation { get; set; }
		[Ordinal(3)]  [RED("expFill")] public inkWidgetReference ExpFill { get; set; }
		[Ordinal(4)]  [RED("expPointText1")] public inkTextWidgetReference ExpPointText1 { get; set; }
		[Ordinal(5)]  [RED("expPointText2")] public inkTextWidgetReference ExpPointText2 { get; set; }
		[Ordinal(6)]  [RED("isLevelUp")] public CBool IsLevelUp { get; set; }
		[Ordinal(7)]  [RED("levelUpAnimation")] public inkWidgetReference LevelUpAnimation { get; set; }
		[Ordinal(8)]  [RED("levelUpBlackboard")] public CHandle<gameIBlackboard> LevelUpBlackboard { get; set; }
		[Ordinal(9)]  [RED("nextLevelText")] public inkTextWidgetReference NextLevelText { get; set; }
		[Ordinal(10)]  [RED("perkHolder")] public inkWidgetReference PerkHolder { get; set; }
		[Ordinal(11)]  [RED("playerLevelUpListener")] public CUInt32 PlayerLevelUpListener { get; set; }

		public CraftingSkillWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
