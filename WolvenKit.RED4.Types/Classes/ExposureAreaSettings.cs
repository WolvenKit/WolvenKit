using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExposureAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<CFloat> _exposureAdaptationSpeedUp;
		private CLegacySingleChannelCurve<CFloat> _exposureAdaptationSpeedDown;
		private CLegacySingleChannelCurve<CFloat> _exposurePercentageThresholdLow;
		private CLegacySingleChannelCurve<CFloat> _exposurePercentageThresholdHigh;
		private CLegacySingleChannelCurve<CFloat> _exposureCompensation;
		private CLegacySingleChannelCurve<CFloat> _exposureSkyImpact;
		private CLegacySingleChannelCurve<CFloat> _exposureMin;
		private CLegacySingleChannelCurve<CFloat> _exposureMax;
		private CLegacySingleChannelCurve<CFloat> _exposureCenterImportance;
		private CFloat _cameraVelocityFaloff;

		[Ordinal(2)] 
		[RED("exposureAdaptationSpeedUp")] 
		public CLegacySingleChannelCurve<CFloat> ExposureAdaptationSpeedUp
		{
			get => GetProperty(ref _exposureAdaptationSpeedUp);
			set => SetProperty(ref _exposureAdaptationSpeedUp, value);
		}

		[Ordinal(3)] 
		[RED("exposureAdaptationSpeedDown")] 
		public CLegacySingleChannelCurve<CFloat> ExposureAdaptationSpeedDown
		{
			get => GetProperty(ref _exposureAdaptationSpeedDown);
			set => SetProperty(ref _exposureAdaptationSpeedDown, value);
		}

		[Ordinal(4)] 
		[RED("exposurePercentageThresholdLow")] 
		public CLegacySingleChannelCurve<CFloat> ExposurePercentageThresholdLow
		{
			get => GetProperty(ref _exposurePercentageThresholdLow);
			set => SetProperty(ref _exposurePercentageThresholdLow, value);
		}

		[Ordinal(5)] 
		[RED("exposurePercentageThresholdHigh")] 
		public CLegacySingleChannelCurve<CFloat> ExposurePercentageThresholdHigh
		{
			get => GetProperty(ref _exposurePercentageThresholdHigh);
			set => SetProperty(ref _exposurePercentageThresholdHigh, value);
		}

		[Ordinal(6)] 
		[RED("exposureCompensation")] 
		public CLegacySingleChannelCurve<CFloat> ExposureCompensation
		{
			get => GetProperty(ref _exposureCompensation);
			set => SetProperty(ref _exposureCompensation, value);
		}

		[Ordinal(7)] 
		[RED("exposureSkyImpact")] 
		public CLegacySingleChannelCurve<CFloat> ExposureSkyImpact
		{
			get => GetProperty(ref _exposureSkyImpact);
			set => SetProperty(ref _exposureSkyImpact, value);
		}

		[Ordinal(8)] 
		[RED("exposureMin")] 
		public CLegacySingleChannelCurve<CFloat> ExposureMin
		{
			get => GetProperty(ref _exposureMin);
			set => SetProperty(ref _exposureMin, value);
		}

		[Ordinal(9)] 
		[RED("exposureMax")] 
		public CLegacySingleChannelCurve<CFloat> ExposureMax
		{
			get => GetProperty(ref _exposureMax);
			set => SetProperty(ref _exposureMax, value);
		}

		[Ordinal(10)] 
		[RED("exposureCenterImportance")] 
		public CLegacySingleChannelCurve<CFloat> ExposureCenterImportance
		{
			get => GetProperty(ref _exposureCenterImportance);
			set => SetProperty(ref _exposureCenterImportance, value);
		}

		[Ordinal(11)] 
		[RED("cameraVelocityFaloff")] 
		public CFloat CameraVelocityFaloff
		{
			get => GetProperty(ref _cameraVelocityFaloff);
			set => SetProperty(ref _cameraVelocityFaloff, value);
		}
	}
}
