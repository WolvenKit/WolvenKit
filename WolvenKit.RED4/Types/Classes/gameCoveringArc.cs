using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCoveringArc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("leftAngle")] 
		public CFloat LeftAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("rightAngle")] 
		public CFloat RightAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("verticalAngle")] 
		public CFloat VerticalAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameCoveringArc()
		{
			LeftAngle = -1.000000F;
			RightAngle = -1.000000F;
			VerticalAngle = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
