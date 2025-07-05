using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsDistanceFromScreenCenterPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("curvature")] 
		public CFloat Curvature
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxPriorityBoundsFactor")] 
		public CFloat MaxPriorityBoundsFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameinteractionsDistanceFromScreenCenterPredicate()
		{
			Height = 1.000000F;
			Width = 1.000000F;
			Curvature = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
