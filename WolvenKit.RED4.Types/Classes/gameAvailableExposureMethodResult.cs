using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAvailableExposureMethodResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("distanceToTarget")] 
		public CFloat DistanceToTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("method")] 
		public CEnum<AICoverExposureMethod> Method
		{
			get => GetPropertyValue<CEnum<AICoverExposureMethod>>();
			set => SetPropertyValue<CEnum<AICoverExposureMethod>>(value);
		}

		public gameAvailableExposureMethodResult()
		{
			DistanceToTarget = 340282346638528859811704183484516925440.000000F;
			Method = Enums.AICoverExposureMethod.Count;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
