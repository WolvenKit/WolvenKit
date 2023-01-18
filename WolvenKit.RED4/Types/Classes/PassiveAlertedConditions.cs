using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PassiveAlertedConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)] 
		[RED("highLevelCbId")] 
		public CUInt32 HighLevelCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("delayEvaluationCbId")] 
		public CUInt32 DelayEvaluationCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PassiveAlertedConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
