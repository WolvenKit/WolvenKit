using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDistanceToExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] 
		[RED("target")] 
		public CHandle<AIbehaviorExpressionSocket> Target
		{
			get => GetPropertyValue<CHandle<AIbehaviorExpressionSocket>>();
			set => SetPropertyValue<CHandle<AIbehaviorExpressionSocket>>(value);
		}

		[Ordinal(1)] 
		[RED("tolerance")] 
		public CFloat Tolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("updatePeriod")] 
		public CFloat UpdatePeriod
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIbehaviorDistanceToExpressionDefinition()
		{
			Tolerance = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
