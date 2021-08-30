using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorDistanceToExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CHandle<AIbehaviorExpressionSocket> _target;
		private CFloat _tolerance;
		private CFloat _updatePeriod;

		[Ordinal(0)] 
		[RED("target")] 
		public CHandle<AIbehaviorExpressionSocket> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("tolerance")] 
		public CFloat Tolerance
		{
			get => GetProperty(ref _tolerance);
			set => SetProperty(ref _tolerance, value);
		}

		[Ordinal(2)] 
		[RED("updatePeriod")] 
		public CFloat UpdatePeriod
		{
			get => GetProperty(ref _updatePeriod);
			set => SetProperty(ref _updatePeriod, value);
		}

		public AIbehaviorDistanceToExpressionDefinition()
		{
			_tolerance = 0.100000F;
		}
	}
}
