using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SkillCheckBase : IScriptable
	{
		private TweakDBID _alternativeName;
		private CEnum<EGameplayChallengeLevel> _difficulty;
		private CHandle<GameplayConditionContainer> _additionalRequirements;
		private CFloat _duration;
		private CBool _isActive;
		private CBool _wasPassed;
		private CBool _skillCheckPerformed;
		private CEnum<EDeviceChallengeSkill> _skillToCheck;
		private CHandle<GameplaySkillCondition> _baseSkill;
		private CBool _isDynamic;

		[Ordinal(0)] 
		[RED("alternativeName")] 
		public TweakDBID AlternativeName
		{
			get
			{
				if (_alternativeName == null)
				{
					_alternativeName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "alternativeName", cr2w, this);
				}
				return _alternativeName;
			}
			set
			{
				if (_alternativeName == value)
				{
					return;
				}
				_alternativeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get
			{
				if (_difficulty == null)
				{
					_difficulty = (CEnum<EGameplayChallengeLevel>) CR2WTypeManager.Create("EGameplayChallengeLevel", "difficulty", cr2w, this);
				}
				return _difficulty;
			}
			set
			{
				if (_difficulty == value)
				{
					return;
				}
				_difficulty = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("additionalRequirements")] 
		public CHandle<GameplayConditionContainer> AdditionalRequirements
		{
			get
			{
				if (_additionalRequirements == null)
				{
					_additionalRequirements = (CHandle<GameplayConditionContainer>) CR2WTypeManager.Create("handle:GameplayConditionContainer", "additionalRequirements", cr2w, this);
				}
				return _additionalRequirements;
			}
			set
			{
				if (_additionalRequirements == value)
				{
					return;
				}
				_additionalRequirements = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("wasPassed")] 
		public CBool WasPassed
		{
			get
			{
				if (_wasPassed == null)
				{
					_wasPassed = (CBool) CR2WTypeManager.Create("Bool", "wasPassed", cr2w, this);
				}
				return _wasPassed;
			}
			set
			{
				if (_wasPassed == value)
				{
					return;
				}
				_wasPassed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("skillCheckPerformed")] 
		public CBool SkillCheckPerformed
		{
			get
			{
				if (_skillCheckPerformed == null)
				{
					_skillCheckPerformed = (CBool) CR2WTypeManager.Create("Bool", "skillCheckPerformed", cr2w, this);
				}
				return _skillCheckPerformed;
			}
			set
			{
				if (_skillCheckPerformed == value)
				{
					return;
				}
				_skillCheckPerformed = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("skillToCheck")] 
		public CEnum<EDeviceChallengeSkill> SkillToCheck
		{
			get
			{
				if (_skillToCheck == null)
				{
					_skillToCheck = (CEnum<EDeviceChallengeSkill>) CR2WTypeManager.Create("EDeviceChallengeSkill", "skillToCheck", cr2w, this);
				}
				return _skillToCheck;
			}
			set
			{
				if (_skillToCheck == value)
				{
					return;
				}
				_skillToCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("baseSkill")] 
		public CHandle<GameplaySkillCondition> BaseSkill
		{
			get
			{
				if (_baseSkill == null)
				{
					_baseSkill = (CHandle<GameplaySkillCondition>) CR2WTypeManager.Create("handle:GameplaySkillCondition", "baseSkill", cr2w, this);
				}
				return _baseSkill;
			}
			set
			{
				if (_baseSkill == value)
				{
					return;
				}
				_baseSkill = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get
			{
				if (_isDynamic == null)
				{
					_isDynamic = (CBool) CR2WTypeManager.Create("Bool", "isDynamic", cr2w, this);
				}
				return _isDynamic;
			}
			set
			{
				if (_isDynamic == value)
				{
					return;
				}
				_isDynamic = value;
				PropertySet(this);
			}
		}

		public SkillCheckBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
