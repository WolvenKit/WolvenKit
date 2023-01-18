using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExposureAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("exposureAdaptationSpeedUp")] 
		public CLegacySingleChannelCurve<CFloat> ExposureAdaptationSpeedUp
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("exposureAdaptationSpeedDown")] 
		public CLegacySingleChannelCurve<CFloat> ExposureAdaptationSpeedDown
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("exposurePercentageThresholdLow")] 
		public CLegacySingleChannelCurve<CFloat> ExposurePercentageThresholdLow
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("exposurePercentageThresholdHigh")] 
		public CLegacySingleChannelCurve<CFloat> ExposurePercentageThresholdHigh
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("exposureCompensation")] 
		public CLegacySingleChannelCurve<CFloat> ExposureCompensation
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("exposureSkyImpact")] 
		public CLegacySingleChannelCurve<CFloat> ExposureSkyImpact
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(8)] 
		[RED("exposureMin")] 
		public CLegacySingleChannelCurve<CFloat> ExposureMin
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("exposureMax")] 
		public CLegacySingleChannelCurve<CFloat> ExposureMax
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(10)] 
		[RED("exposureCenterImportance")] 
		public CLegacySingleChannelCurve<CFloat> ExposureCenterImportance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(11)] 
		[RED("cameraVelocityFaloff")] 
		public CFloat CameraVelocityFaloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ExposureAreaSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
