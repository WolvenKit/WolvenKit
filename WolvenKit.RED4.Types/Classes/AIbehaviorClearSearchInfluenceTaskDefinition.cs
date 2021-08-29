using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorClearSearchInfluenceTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _clearedAreaRadius;
		private CHandle<AIArgumentMapping> _clearedAreaDistance;
		private CHandle<AIArgumentMapping> _clearedAreaAngle;

		[Ordinal(1)] 
		[RED("clearedAreaRadius")] 
		public CHandle<AIArgumentMapping> ClearedAreaRadius
		{
			get => GetProperty(ref _clearedAreaRadius);
			set => SetProperty(ref _clearedAreaRadius, value);
		}

		[Ordinal(2)] 
		[RED("clearedAreaDistance")] 
		public CHandle<AIArgumentMapping> ClearedAreaDistance
		{
			get => GetProperty(ref _clearedAreaDistance);
			set => SetProperty(ref _clearedAreaDistance, value);
		}

		[Ordinal(3)] 
		[RED("clearedAreaAngle")] 
		public CHandle<AIArgumentMapping> ClearedAreaAngle
		{
			get => GetProperty(ref _clearedAreaAngle);
			set => SetProperty(ref _clearedAreaAngle, value);
		}
	}
}
