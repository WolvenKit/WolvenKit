using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleWheelRuntimePSData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("previousTouchedMaterial")] 
		public CName PreviousTouchedMaterial
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("previousVisualDisplacement")] 
		public CFloat PreviousVisualDisplacement
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("previousLogicalSpringCompression")] 
		public CFloat PreviousLogicalSpringCompression
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("previousSwaybarDisplacement")] 
		public CFloat PreviousSwaybarDisplacement
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("previousDampedSpringForce")] 
		public CFloat PreviousDampedSpringForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleWheelRuntimePSData()
		{
			PreviousVisualDisplacement = -340282346638528859811704183484516925440.000000F;
			PreviousLogicalSpringCompression = -340282346638528859811704183484516925440.000000F;
			PreviousSwaybarDisplacement = -340282346638528859811704183484516925440.000000F;
			PreviousDampedSpringForce = -340282346638528859811704183484516925440.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
