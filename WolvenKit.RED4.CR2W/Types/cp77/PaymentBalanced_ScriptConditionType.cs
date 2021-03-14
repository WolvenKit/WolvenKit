using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaymentBalanced_ScriptConditionType : PaymentConditionTypeBase
	{
		private TweakDBID _questAssignment;
		private CEnum<EGameplayChallengeLevel> _difficulty;

		[Ordinal(2)] 
		[RED("questAssignment")] 
		public TweakDBID QuestAssignment
		{
			get
			{
				if (_questAssignment == null)
				{
					_questAssignment = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "questAssignment", cr2w, this);
				}
				return _questAssignment;
			}
			set
			{
				if (_questAssignment == value)
				{
					return;
				}
				_questAssignment = value;
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

		public PaymentBalanced_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
