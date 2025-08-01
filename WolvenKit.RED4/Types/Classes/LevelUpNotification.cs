using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LevelUpNotification : GenericNotificationController
	{
		[Ordinal(16)] 
		[RED("levelupData")] 
		public CHandle<gameuiLevelUpNotificationViewData> LevelupData
		{
			get => GetPropertyValue<CHandle<gameuiLevelUpNotificationViewData>>();
			set => SetPropertyValue<CHandle<gameuiLevelUpNotificationViewData>>(value);
		}

		[Ordinal(17)] 
		[RED("animation")] 
		public CHandle<inkanimProxy> Animation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("bonusRecord")] 
		public CHandle<gamedataPassiveProficiencyBonus_Record> BonusRecord
		{
			get => GetPropertyValue<CHandle<gamedataPassiveProficiencyBonus_Record>>();
			set => SetPropertyValue<CHandle<gamedataPassiveProficiencyBonus_Record>>(value);
		}

		[Ordinal(19)] 
		[RED("LevelUpLabelText")] 
		public inkTextWidgetReference LevelUpLabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("LevelUpValue")] 
		public inkTextWidgetReference LevelUpValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("LevelUpHolder")] 
		public inkWidgetReference LevelUpHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("LevelUpPreviousValue")] 
		public inkTextWidgetReference LevelUpPreviousValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("AttributePointsValue")] 
		public inkTextWidgetReference AttributePointsValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("AttributePointsPreviousValue")] 
		public inkTextWidgetReference AttributePointsPreviousValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("AttributePointsHolder")] 
		public inkWidgetReference AttributePointsHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("PerkPointsValue")] 
		public inkTextWidgetReference PerkPointsValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("PerkPreviousValue")] 
		public inkTextWidgetReference PerkPreviousValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("SkillIcon")] 
		public inkImageWidgetReference SkillIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("SkillIconShadow")] 
		public inkImageWidgetReference SkillIconShadow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("bonusDisplay")] 
		public CHandle<LevelRewardDisplayData> BonusDisplay
		{
			get => GetPropertyValue<CHandle<LevelRewardDisplayData>>();
			set => SetPropertyValue<CHandle<LevelRewardDisplayData>>(value);
		}

		[Ordinal(31)] 
		[RED("passiveBonusRewardLabel")] 
		public inkTextWidgetReference PassiveBonusRewardLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("passiveBonusReward")] 
		public inkWidgetReference PassiveBonusReward
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("unlockedActivites")] 
		public CInt32 UnlockedActivites
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public LevelUpNotification()
		{
			CustomInputActionName = "NotificationOpenLvlup";
			LevelUpLabelText = new inkTextWidgetReference();
			LevelUpValue = new inkTextWidgetReference();
			LevelUpHolder = new inkWidgetReference();
			LevelUpPreviousValue = new inkTextWidgetReference();
			AttributePointsValue = new inkTextWidgetReference();
			AttributePointsPreviousValue = new inkTextWidgetReference();
			AttributePointsHolder = new inkWidgetReference();
			PerkPointsValue = new inkTextWidgetReference();
			PerkPreviousValue = new inkTextWidgetReference();
			SkillIcon = new inkImageWidgetReference();
			SkillIconShadow = new inkImageWidgetReference();
			PassiveBonusRewardLabel = new inkTextWidgetReference();
			PassiveBonusReward = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
