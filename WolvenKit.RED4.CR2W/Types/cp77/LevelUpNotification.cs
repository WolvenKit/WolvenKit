using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelUpNotification : GenericNotificationController
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
			get
			{
				if (_levelup_data == null)
				{
					_levelup_data = (CHandle<gameuiLevelUpNotificationViewData>) CR2WTypeManager.Create("handle:gameuiLevelUpNotificationViewData", "levelup_data", cr2w, this);
				}
				return _levelup_data;
			}
			set
			{
				if (_levelup_data == value)
				{
					return;
				}
				_levelup_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animation")] 
		public CHandle<inkanimProxy> Animation
		{
			get
			{
				if (_animation == null)
				{
					_animation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animation", cr2w, this);
				}
				return _animation;
			}
			set
			{
				if (_animation == value)
				{
					return;
				}
				_animation = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bonusRecord")] 
		public CHandle<gamedataPassiveProficiencyBonus_Record> BonusRecord
		{
			get
			{
				if (_bonusRecord == null)
				{
					_bonusRecord = (CHandle<gamedataPassiveProficiencyBonus_Record>) CR2WTypeManager.Create("handle:gamedataPassiveProficiencyBonus_Record", "bonusRecord", cr2w, this);
				}
				return _bonusRecord;
			}
			set
			{
				if (_bonusRecord == value)
				{
					return;
				}
				_bonusRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("LevelUpLabelText")] 
		public inkTextWidgetReference LevelUpLabelText
		{
			get
			{
				if (_levelUpLabelText == null)
				{
					_levelUpLabelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "LevelUpLabelText", cr2w, this);
				}
				return _levelUpLabelText;
			}
			set
			{
				if (_levelUpLabelText == value)
				{
					return;
				}
				_levelUpLabelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("LevelUpValue")] 
		public inkTextWidgetReference LevelUpValue
		{
			get
			{
				if (_levelUpValue == null)
				{
					_levelUpValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "LevelUpValue", cr2w, this);
				}
				return _levelUpValue;
			}
			set
			{
				if (_levelUpValue == value)
				{
					return;
				}
				_levelUpValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("LevelUpHolder")] 
		public inkWidgetReference LevelUpHolder
		{
			get
			{
				if (_levelUpHolder == null)
				{
					_levelUpHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "LevelUpHolder", cr2w, this);
				}
				return _levelUpHolder;
			}
			set
			{
				if (_levelUpHolder == value)
				{
					return;
				}
				_levelUpHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("LevelUpPreviousValue")] 
		public inkTextWidgetReference LevelUpPreviousValue
		{
			get
			{
				if (_levelUpPreviousValue == null)
				{
					_levelUpPreviousValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "LevelUpPreviousValue", cr2w, this);
				}
				return _levelUpPreviousValue;
			}
			set
			{
				if (_levelUpPreviousValue == value)
				{
					return;
				}
				_levelUpPreviousValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("AttributePointsValue")] 
		public inkTextWidgetReference AttributePointsValue
		{
			get
			{
				if (_attributePointsValue == null)
				{
					_attributePointsValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "AttributePointsValue", cr2w, this);
				}
				return _attributePointsValue;
			}
			set
			{
				if (_attributePointsValue == value)
				{
					return;
				}
				_attributePointsValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("AttributePointsPreviousValue")] 
		public inkTextWidgetReference AttributePointsPreviousValue
		{
			get
			{
				if (_attributePointsPreviousValue == null)
				{
					_attributePointsPreviousValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "AttributePointsPreviousValue", cr2w, this);
				}
				return _attributePointsPreviousValue;
			}
			set
			{
				if (_attributePointsPreviousValue == value)
				{
					return;
				}
				_attributePointsPreviousValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("AttributePointsHolder")] 
		public inkWidgetReference AttributePointsHolder
		{
			get
			{
				if (_attributePointsHolder == null)
				{
					_attributePointsHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "AttributePointsHolder", cr2w, this);
				}
				return _attributePointsHolder;
			}
			set
			{
				if (_attributePointsHolder == value)
				{
					return;
				}
				_attributePointsHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("PerkPointsValue")] 
		public inkTextWidgetReference PerkPointsValue
		{
			get
			{
				if (_perkPointsValue == null)
				{
					_perkPointsValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "PerkPointsValue", cr2w, this);
				}
				return _perkPointsValue;
			}
			set
			{
				if (_perkPointsValue == value)
				{
					return;
				}
				_perkPointsValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("PerkPreviousValue")] 
		public inkTextWidgetReference PerkPreviousValue
		{
			get
			{
				if (_perkPreviousValue == null)
				{
					_perkPreviousValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "PerkPreviousValue", cr2w, this);
				}
				return _perkPreviousValue;
			}
			set
			{
				if (_perkPreviousValue == value)
				{
					return;
				}
				_perkPreviousValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("SkillIcon")] 
		public inkImageWidgetReference SkillIcon
		{
			get
			{
				if (_skillIcon == null)
				{
					_skillIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "SkillIcon", cr2w, this);
				}
				return _skillIcon;
			}
			set
			{
				if (_skillIcon == value)
				{
					return;
				}
				_skillIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("SkillIconShadow")] 
		public inkImageWidgetReference SkillIconShadow
		{
			get
			{
				if (_skillIconShadow == null)
				{
					_skillIconShadow = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "SkillIconShadow", cr2w, this);
				}
				return _skillIconShadow;
			}
			set
			{
				if (_skillIconShadow == value)
				{
					return;
				}
				_skillIconShadow = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("bonusDisplay")] 
		public CHandle<LevelRewardDisplayData> BonusDisplay
		{
			get
			{
				if (_bonusDisplay == null)
				{
					_bonusDisplay = (CHandle<LevelRewardDisplayData>) CR2WTypeManager.Create("handle:LevelRewardDisplayData", "bonusDisplay", cr2w, this);
				}
				return _bonusDisplay;
			}
			set
			{
				if (_bonusDisplay == value)
				{
					return;
				}
				_bonusDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("passiveBonusRewardLabel")] 
		public inkTextWidgetReference PassiveBonusRewardLabel
		{
			get
			{
				if (_passiveBonusRewardLabel == null)
				{
					_passiveBonusRewardLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "passiveBonusRewardLabel", cr2w, this);
				}
				return _passiveBonusRewardLabel;
			}
			set
			{
				if (_passiveBonusRewardLabel == value)
				{
					return;
				}
				_passiveBonusRewardLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("passiveBonusReward")] 
		public inkWidgetReference PassiveBonusReward
		{
			get
			{
				if (_passiveBonusReward == null)
				{
					_passiveBonusReward = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "passiveBonusReward", cr2w, this);
				}
				return _passiveBonusReward;
			}
			set
			{
				if (_passiveBonusReward == value)
				{
					return;
				}
				_passiveBonusReward = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("unlockedActivites")] 
		public CInt32 UnlockedActivites
		{
			get
			{
				if (_unlockedActivites == null)
				{
					_unlockedActivites = (CInt32) CR2WTypeManager.Create("Int32", "unlockedActivites", cr2w, this);
				}
				return _unlockedActivites;
			}
			set
			{
				if (_unlockedActivites == value)
				{
					return;
				}
				_unlockedActivites = value;
				PropertySet(this);
			}
		}

		public LevelUpNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
