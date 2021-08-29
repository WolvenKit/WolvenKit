using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GetTargetLastKnownPosition : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inTargetObject;
		private CHandle<AIArgumentMapping> _outPosition;
		private CFloat _predictionTime;

		[Ordinal(0)] 
		[RED("inTargetObject")] 
		public CHandle<AIArgumentMapping> InTargetObject
		{
			get => GetProperty(ref _inTargetObject);
			set => SetProperty(ref _inTargetObject, value);
		}

		[Ordinal(1)] 
		[RED("outPosition")] 
		public CHandle<AIArgumentMapping> OutPosition
		{
			get => GetProperty(ref _outPosition);
			set => SetProperty(ref _outPosition, value);
		}

		[Ordinal(2)] 
		[RED("predictionTime")] 
		public CFloat PredictionTime
		{
			get => GetProperty(ref _predictionTime);
			set => SetProperty(ref _predictionTime, value);
		}
	}
}
