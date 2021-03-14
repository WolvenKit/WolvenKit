using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplaySkillCondition : GameplayConditionBase
	{
		private TweakDBID _skillToCheck;
		private CEnum<EGameplayChallengeLevel> _difficulty;

		[Ordinal(1)] 
		[RED("skillToCheck")] 
		public TweakDBID SkillToCheck
		{
			get
			{
				if (_skillToCheck == null)
				{
					_skillToCheck = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "skillToCheck", cr2w, this);
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

		[Ordinal(2)] 
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

		public GameplaySkillCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
