using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayPerkCondition : GameplayConditionBase
	{
		private TweakDBID _perkToCheck;
		private CEnum<EGameplayChallengeLevel> _difficulty;

		[Ordinal(1)] 
		[RED("perkToCheck")] 
		public TweakDBID PerkToCheck
		{
			get
			{
				if (_perkToCheck == null)
				{
					_perkToCheck = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "perkToCheck", cr2w, this);
				}
				return _perkToCheck;
			}
			set
			{
				if (_perkToCheck == value)
				{
					return;
				}
				_perkToCheck = value;
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

		public GameplayPerkCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
