using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LevelUpNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("AttributePointsHolder")] public inkWidgetReference AttributePointsHolder { get; set; }
		[Ordinal(1)]  [RED("AttributePointsPreviousValue")] public inkTextWidgetReference AttributePointsPreviousValue { get; set; }
		[Ordinal(2)]  [RED("AttributePointsValue")] public inkTextWidgetReference AttributePointsValue { get; set; }
		[Ordinal(3)]  [RED("LevelUpHolder")] public inkWidgetReference LevelUpHolder { get; set; }
		[Ordinal(4)]  [RED("LevelUpLabelText")] public inkTextWidgetReference LevelUpLabelText { get; set; }
		[Ordinal(5)]  [RED("LevelUpPreviousValue")] public inkTextWidgetReference LevelUpPreviousValue { get; set; }
		[Ordinal(6)]  [RED("LevelUpValue")] public inkTextWidgetReference LevelUpValue { get; set; }
		[Ordinal(7)]  [RED("PerkPointsValue")] public inkTextWidgetReference PerkPointsValue { get; set; }
		[Ordinal(8)]  [RED("PerkPreviousValue")] public inkTextWidgetReference PerkPreviousValue { get; set; }
		[Ordinal(9)]  [RED("SkillIcon")] public inkImageWidgetReference SkillIcon { get; set; }
		[Ordinal(10)]  [RED("SkillIconShadow")] public inkImageWidgetReference SkillIconShadow { get; set; }
		[Ordinal(11)]  [RED("animation")] public CHandle<inkanimProxy> Animation { get; set; }
		[Ordinal(12)]  [RED("bonusDisplay")] public CHandle<LevelRewardDisplayData> BonusDisplay { get; set; }
		[Ordinal(13)]  [RED("bonusRecord")] public CHandle<gamedataPassiveProficiencyBonus_Record> BonusRecord { get; set; }
		[Ordinal(14)]  [RED("levelup_data")] public CHandle<gameuiLevelUpNotificationViewData> Levelup_data { get; set; }
		[Ordinal(15)]  [RED("passiveBonusReward")] public inkWidgetReference PassiveBonusReward { get; set; }
		[Ordinal(16)]  [RED("passiveBonusRewardLabel")] public inkTextWidgetReference PassiveBonusRewardLabel { get; set; }
		[Ordinal(17)]  [RED("unlockedActivites")] public CInt32 UnlockedActivites { get; set; }

		public LevelUpNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
