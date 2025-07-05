using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseVisibleObjectetSecondaryDistanceEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("extraEvaluationDistance")] 
		public CFloat ExtraEvaluationDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public senseVisibleObjectetSecondaryDistanceEvent()
		{
			Distance = float.MaxValue;
			ExtraEvaluationDistance = float.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
