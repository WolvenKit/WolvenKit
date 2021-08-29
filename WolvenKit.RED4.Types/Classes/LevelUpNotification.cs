using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LevelUpNotification : GenericNotificationController
	{
		private CHandle<gameuiLevelUpNotificationViewData> _levelup_data;
		private CHandle<inkanimProxy> _animation;
		private CHandle<gamedataPassiveProficiencyBonus_Record> _bonusRecord;
		private inkTextWidgetReference _levelUpLabelText;
		private inkTextWidgetReference _levelUpValue;
		private inkWidgetReference _levelUpHolder;
		private inkTextWidgetReference _levelUpPreviousValue;
		private inkTextWidgetReference _attributePointsValue;
		private inkTextWidgetReference _attributePointsPreviousValue;
		private inkWidgetReference _attributePointsHolder;
		private inkTextWidgetReference _perkPointsValue;
		private inkTextWidgetReference _perkPreviousValue;
		private inkImageWidgetReference _skillIcon;
		private inkImageWidgetReference _skillIconShadow;
		private CHandle<LevelRewardDisplayData> _bonusDisplay;
		private inkTextWidgetReference _passiveBonusRewardLabel;
		private inkWidgetReference _passiveBonusReward;
		private CInt32 _unlockedActivites;

		[Ordinal(12)] 
		[RED("levelup_data")] 
		public CHandle<gameuiLevelUpNotificationViewData> Levelup_data
		{
			get => GetProperty(ref _levelup_data);
			set => SetProperty(ref _levelup_data, value);
		}

		[Ordinal(13)] 
		[RED("animation")] 
		public CHandle<inkanimProxy> Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(14)] 
		[RED("bonusRecord")] 
		public CHandle<gamedataPassiveProficiencyBonus_Record> BonusRecord
		{
			get => GetProperty(ref _bonusRecord);
			set => SetProperty(ref _bonusRecord, value);
		}

		[Ordinal(15)] 
		[RED("LevelUpLabelText")] 
		public inkTextWidgetReference LevelUpLabelText
		{
			get => GetProperty(ref _levelUpLabelText);
			set => SetProperty(ref _levelUpLabelText, value);
		}

		[Ordinal(16)] 
		[RED("LevelUpValue")] 
		public inkTextWidgetReference LevelUpValue
		{
			get => GetProperty(ref _levelUpValue);
			set => SetProperty(ref _levelUpValue, value);
		}

		[Ordinal(17)] 
		[RED("LevelUpHolder")] 
		public inkWidgetReference LevelUpHolder
		{
			get => GetProperty(ref _levelUpHolder);
			set => SetProperty(ref _levelUpHolder, value);
		}

		[Ordinal(18)] 
		[RED("LevelUpPreviousValue")] 
		public inkTextWidgetReference LevelUpPreviousValue
		{
			get => GetProperty(ref _levelUpPreviousValue);
			set => SetProperty(ref _levelUpPreviousValue, value);
		}

		[Ordinal(19)] 
		[RED("AttributePointsValue")] 
		public inkTextWidgetReference AttributePointsValue
		{
			get => GetProperty(ref _attributePointsValue);
			set => SetProperty(ref _attributePointsValue, value);
		}

		[Ordinal(20)] 
		[RED("AttributePointsPreviousValue")] 
		public inkTextWidgetReference AttributePointsPreviousValue
		{
			get => GetProperty(ref _attributePointsPreviousValue);
			set => SetProperty(ref _attributePointsPreviousValue, value);
		}

		[Ordinal(21)] 
		[RED("AttributePointsHolder")] 
		public inkWidgetReference AttributePointsHolder
		{
			get => GetProperty(ref _attributePointsHolder);
			set => SetProperty(ref _attributePointsHolder, value);
		}

		[Ordinal(22)] 
		[RED("PerkPointsValue")] 
		public inkTextWidgetReference PerkPointsValue
		{
			get => GetProperty(ref _perkPointsValue);
			set => SetProperty(ref _perkPointsValue, value);
		}

		[Ordinal(23)] 
		[RED("PerkPreviousValue")] 
		public inkTextWidgetReference PerkPreviousValue
		{
			get => GetProperty(ref _perkPreviousValue);
			set => SetProperty(ref _perkPreviousValue, value);
		}

		[Ordinal(24)] 
		[RED("SkillIcon")] 
		public inkImageWidgetReference SkillIcon
		{
			get => GetProperty(ref _skillIcon);
			set => SetProperty(ref _skillIcon, value);
		}

		[Ordinal(25)] 
		[RED("SkillIconShadow")] 
		public inkImageWidgetReference SkillIconShadow
		{
			get => GetProperty(ref _skillIconShadow);
			set => SetProperty(ref _skillIconShadow, value);
		}

		[Ordinal(26)] 
		[RED("bonusDisplay")] 
		public CHandle<LevelRewardDisplayData> BonusDisplay
		{
			get => GetProperty(ref _bonusDisplay);
			set => SetProperty(ref _bonusDisplay, value);
		}

		[Ordinal(27)] 
		[RED("passiveBonusRewardLabel")] 
		public inkTextWidgetReference PassiveBonusRewardLabel
		{
			get => GetProperty(ref _passiveBonusRewardLabel);
			set => SetProperty(ref _passiveBonusRewardLabel, value);
		}

		[Ordinal(28)] 
		[RED("passiveBonusReward")] 
		public inkWidgetReference PassiveBonusReward
		{
			get => GetProperty(ref _passiveBonusReward);
			set => SetProperty(ref _passiveBonusReward, value);
		}

		[Ordinal(29)] 
		[RED("unlockedActivites")] 
		public CInt32 UnlockedActivites
		{
			get => GetProperty(ref _unlockedActivites);
			set => SetProperty(ref _unlockedActivites, value);
		}
	}
}
