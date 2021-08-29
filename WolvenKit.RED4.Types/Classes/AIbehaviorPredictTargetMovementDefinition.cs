using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorPredictTargetMovementDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _timeInterval;
		private CHandle<AIArgumentMapping> _result;

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("timeInterval")] 
		public CHandle<AIArgumentMapping> TimeInterval
		{
			get => GetProperty(ref _timeInterval);
			set => SetProperty(ref _timeInterval, value);
		}

		[Ordinal(3)] 
		[RED("result")] 
		public CHandle<AIArgumentMapping> Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}
	}
}
