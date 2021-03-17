using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExposureAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _exposureAdaptationSpeedUp;
		private curveData<CFloat> _exposureAdaptationSpeedDown;
		private curveData<CFloat> _exposurePercentageThresholdLow;
		private curveData<CFloat> _exposurePercentageThresholdHigh;
		private curveData<CFloat> _exposureCompensation;
		private curveData<CFloat> _exposureSkyImpact;
		private curveData<CFloat> _exposureMin;
		private curveData<CFloat> _exposureMax;
		private curveData<CFloat> _exposureCenterImportance;
		private CFloat _cameraVelocityFaloff;

		[Ordinal(2)] 
		[RED("exposureAdaptationSpeedUp")] 
		public curveData<CFloat> ExposureAdaptationSpeedUp
		{
			get => GetProperty(ref _exposureAdaptationSpeedUp);
			set => SetProperty(ref _exposureAdaptationSpeedUp, value);
		}

		[Ordinal(3)] 
		[RED("exposureAdaptationSpeedDown")] 
		public curveData<CFloat> ExposureAdaptationSpeedDown
		{
			get => GetProperty(ref _exposureAdaptationSpeedDown);
			set => SetProperty(ref _exposureAdaptationSpeedDown, value);
		}

		[Ordinal(4)] 
		[RED("exposurePercentageThresholdLow")] 
		public curveData<CFloat> ExposurePercentageThresholdLow
		{
			get => GetProperty(ref _exposurePercentageThresholdLow);
			set => SetProperty(ref _exposurePercentageThresholdLow, value);
		}

		[Ordinal(5)] 
		[RED("exposurePercentageThresholdHigh")] 
		public curveData<CFloat> ExposurePercentageThresholdHigh
		{
			get => GetProperty(ref _exposurePercentageThresholdHigh);
			set => SetProperty(ref _exposurePercentageThresholdHigh, value);
		}

		[Ordinal(6)] 
		[RED("exposureCompensation")] 
		public curveData<CFloat> ExposureCompensation
		{
			get => GetProperty(ref _exposureCompensation);
			set => SetProperty(ref _exposureCompensation, value);
		}

		[Ordinal(7)] 
		[RED("exposureSkyImpact")] 
		public curveData<CFloat> ExposureSkyImpact
		{
			get => GetProperty(ref _exposureSkyImpact);
			set => SetProperty(ref _exposureSkyImpact, value);
		}

		[Ordinal(8)] 
		[RED("exposureMin")] 
		public curveData<CFloat> ExposureMin
		{
			get => GetProperty(ref _exposureMin);
			set => SetProperty(ref _exposureMin, value);
		}

		[Ordinal(9)] 
		[RED("exposureMax")] 
		public curveData<CFloat> ExposureMax
		{
			get => GetProperty(ref _exposureMax);
			set => SetProperty(ref _exposureMax, value);
		}

		[Ordinal(10)] 
		[RED("exposureCenterImportance")] 
		public curveData<CFloat> ExposureCenterImportance
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

		public ExposureAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
