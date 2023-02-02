using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtPartsDependency : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("masterPart")] 
		public CName MasterPart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("slavePart")] 
		public CName SlavePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("speedToTargetFactor")] 
		public CFloat SpeedToTargetFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("speedToTargetByAngleCurve")] 
		public CLegacySingleChannelCurve<CFloat> SpeedToTargetByAngleCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("verticalPullSpeedFactor")] 
		public CFloat VerticalPullSpeedFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("verticalPullSpeedByAngleCurve")] 
		public CLegacySingleChannelCurve<CFloat> VerticalPullSpeedByAngleCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("horizontalPullSpeedFactor")] 
		public CFloat HorizontalPullSpeedFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("horizontalPullSpeedByAngleCurve")] 
		public CLegacySingleChannelCurve<CFloat> HorizontalPullSpeedByAngleCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("pullScaleBySquareSizeFactor")] 
		public CFloat PullScaleBySquareSizeFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("pullScaleBySquareSizeCurve")] 
		public CLegacySingleChannelCurve<CFloat> PullScaleBySquareSizeCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(11)] 
		[RED("innerSquareScale")] 
		public CFloat InnerSquareScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animLookAtPartsDependency()
		{
			Angle = 10.000000F;
			SpeedToTargetFactor = 1.000000F;
			VerticalPullSpeedFactor = 1.000000F;
			HorizontalPullSpeedFactor = 1.000000F;
			PullScaleBySquareSizeFactor = 1.000000F;
			InnerSquareScale = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
