using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LevelUpNotification : GenericNotificationController
	{
		[Ordinal(12)] [RED("levelup_data")] public CHandle<gameuiLevelUpNotificationViewData> Levelup_data { get; set; }
		[Ordinal(13)] [RED("animation")] public CHandle<inkanimProxy> Animation { get; set; }
		[Ordinal(14)] [RED("bonusRecord")] public CHandle<gamedataPassiveProficiencyBonus_Record> BonusRecord { get; set; }
		[Ordinal(15)] [RED("LevelUpLabelText")] public inkTextWidgetReference LevelUpLabelText { get; set; }
		[Ordinal(16)] [RED("LevelUpValue")] public inkTextWidgetReference LevelUpValue { get; set; }
		[Ordinal(17)] [RED("LevelUpHolder")] public inkWidgetReference LevelUpHolder { get; set; }
		[Ordinal(18)] [RED("LevelUpPreviousValue")] public inkTextWidgetReference LevelUpPreviousValue { get; set; }
		[Ordinal(19)] [RED("AttributePointsValue")] public inkTextWidgetReference AttributePointsValue { get; set; }
		[Ordinal(20)] [RED("AttributePointsPreviousValue")] public inkTextWidgetReference AttributePointsPreviousValue { get; set; }
		[Ordinal(21)] [RED("AttributePointsHolder")] public inkWidgetReference AttributePointsHolder { get; set; }
		[Ordinal(22)] [RED("PerkPointsValue")] public inkTextWidgetReference PerkPointsValue { get; set; }
		[Ordinal(23)] [RED("PerkPreviousValue")] public inkTextWidgetReference PerkPreviousValue { get; set; }
		[Ordinal(24)] [RED("SkillIcon")] public inkImageWidgetReference SkillIcon { get; set; }
		[Ordinal(25)] [RED("SkillIconShadow")] public inkImageWidgetReference SkillIconShadow { get; set; }
		[Ordinal(26)] [RED("bonusDisplay")] public CHandle<LevelRewardDisplayData> BonusDisplay { get; set; }
		[Ordinal(27)] [RED("passiveBonusRewardLabel")] public inkTextWidgetReference PassiveBonusRewardLabel { get; set; }
		[Ordinal(28)] [RED("passiveBonusReward")] public inkWidgetReference PassiveBonusReward { get; set; }
		[Ordinal(29)] [RED("unlockedActivites")] public CInt32 UnlockedActivites { get; set; }

		public LevelUpNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
