using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayStatCondition : GameplayConditionBase
	{
		private TweakDBID _statToCheck;
		private CEnum<EDeviceChallengeAttribute> _stat;
		private CEnum<EGameplayChallengeLevel> _difficulty;

		[Ordinal(1)] 
		[RED("statToCheck")] 
		public TweakDBID StatToCheck
		{
			get
			{
				if (_statToCheck == null)
				{
					_statToCheck = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statToCheck", cr2w, this);
				}
				return _statToCheck;
			}
			set
			{
				if (_statToCheck == value)
				{
					return;
				}
				_statToCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stat")] 
		public CEnum<EDeviceChallengeAttribute> Stat
		{
			get
			{
				if (_stat == null)
				{
					_stat = (CEnum<EDeviceChallengeAttribute>) CR2WTypeManager.Create("EDeviceChallengeAttribute", "stat", cr2w, this);
				}
				return _stat;
			}
			set
			{
				if (_stat == value)
				{
					return;
				}
				_stat = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public GameplayStatCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
