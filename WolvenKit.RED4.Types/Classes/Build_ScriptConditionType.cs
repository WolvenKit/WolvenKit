using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Build_ScriptConditionType : BluelineConditionTypeBase
	{
		private TweakDBID _questAssignment;
		private TweakDBID _buildId;
		private CEnum<EGameplayChallengeLevel> _difficulty;
		private CEnum<ECompareOp> _comparisonType;

		[Ordinal(0)] 
		[RED("questAssignment")] 
		public TweakDBID QuestAssignment
		{
			get => GetProperty(ref _questAssignment);
			set => SetProperty(ref _questAssignment, value);
		}

		[Ordinal(1)] 
		[RED("buildId")] 
		public TweakDBID BuildId
		{
			get => GetProperty(ref _buildId);
			set => SetProperty(ref _buildId, value);
		}

		[Ordinal(2)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetProperty(ref _difficulty);
			set => SetProperty(ref _difficulty, value);
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<ECompareOp> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}
	}
}
