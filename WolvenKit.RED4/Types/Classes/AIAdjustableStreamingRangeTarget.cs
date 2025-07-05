using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIAdjustableStreamingRangeTarget : gameObject
	{
		[Ordinal(36)] 
		[RED("minStreamingDistance")] 
		public CFloat MinStreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIAdjustableStreamingRangeTarget()
		{
			MinStreamingDistance = 30.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
