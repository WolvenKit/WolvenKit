using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PassiveAlertedConditions : PassiveAutonomousCondition
	{
		private CUInt32 _highLevelCbId;
		private CUInt32 _delayEvaluationCbId;

		[Ordinal(0)] 
		[RED("highLevelCbId")] 
		public CUInt32 HighLevelCbId
		{
			get => GetProperty(ref _highLevelCbId);
			set => SetProperty(ref _highLevelCbId, value);
		}

		[Ordinal(1)] 
		[RED("delayEvaluationCbId")] 
		public CUInt32 DelayEvaluationCbId
		{
			get => GetProperty(ref _delayEvaluationCbId);
			set => SetProperty(ref _delayEvaluationCbId, value);
		}
	}
}
