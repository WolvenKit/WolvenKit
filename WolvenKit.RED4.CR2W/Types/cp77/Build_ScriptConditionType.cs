using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Build_ScriptConditionType : BluelineConditionTypeBase
	{
		private TweakDBID _questAssignment;
		private TweakDBID _buildId;
		private CEnum<EGameplayChallengeLevel> _difficulty;
		private CEnum<ECompareOp> _comparisonType;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("buildId")] 
		public TweakDBID BuildId
		{
			get
			{
				if (_buildId == null)
				{
					_buildId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "buildId", cr2w, this);
				}
				return _buildId;
			}
			set
			{
				if (_buildId == value)
				{
					return;
				}
				_buildId = value;
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

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<ECompareOp> ComparisonType
		{
			get
			{
				if (_comparisonType == null)
				{
					_comparisonType = (CEnum<ECompareOp>) CR2WTypeManager.Create("ECompareOp", "comparisonType", cr2w, this);
				}
				return _comparisonType;
			}
			set
			{
				if (_comparisonType == value)
				{
					return;
				}
				_comparisonType = value;
				PropertySet(this);
			}
		}

		public Build_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
