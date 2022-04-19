using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TimeBetweenHitsParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("baseCoefficient")] 
		public CFloat BaseCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("baseSourceCoefficient")] 
		public CFloat BaseSourceCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("difficultyLevelCoefficient")] 
		public CFloat DifficultyLevelCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("groupCoefficient")] 
		public CFloat GroupCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("distanceCoefficient")] 
		public CFloat DistanceCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("visibilityCoefficient")] 
		public CFloat VisibilityCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("playersCountCoefficient")] 
		public CFloat PlayersCountCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("coefficientMultiplier")] 
		public CFloat CoefficientMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("accuracyCoefficient")] 
		public CFloat AccuracyCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public TimeBetweenHitsParameters()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
