using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSpeedSplineNodeSpeedChangeSection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("start")] 
		public CFloat Start
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("end")] 
		public CFloat End
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("targetSpeed_M_P_S")] 
		public CFloat TargetSpeed_M_P_S
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldSpeedSplineNodeSpeedChangeSection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
