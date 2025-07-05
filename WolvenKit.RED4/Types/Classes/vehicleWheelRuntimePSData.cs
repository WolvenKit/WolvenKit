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
			PreviousVisualDisplacement = float.MinValue;
			PreviousLogicalSpringCompression = float.MinValue;
			PreviousSwaybarDisplacement = float.MinValue;
			PreviousDampedSpringForce = float.MinValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
