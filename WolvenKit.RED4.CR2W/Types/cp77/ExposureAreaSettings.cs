using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExposureAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("exposureAdaptationSpeedUp")] public curveData<CFloat> ExposureAdaptationSpeedUp { get; set; }
		[Ordinal(3)] [RED("exposureAdaptationSpeedDown")] public curveData<CFloat> ExposureAdaptationSpeedDown { get; set; }
		[Ordinal(4)] [RED("exposurePercentageThresholdLow")] public curveData<CFloat> ExposurePercentageThresholdLow { get; set; }
		[Ordinal(5)] [RED("exposurePercentageThresholdHigh")] public curveData<CFloat> ExposurePercentageThresholdHigh { get; set; }
		[Ordinal(6)] [RED("exposureCompensation")] public curveData<CFloat> ExposureCompensation { get; set; }
		[Ordinal(7)] [RED("exposureSkyImpact")] public curveData<CFloat> ExposureSkyImpact { get; set; }
		[Ordinal(8)] [RED("exposureMin")] public curveData<CFloat> ExposureMin { get; set; }
		[Ordinal(9)] [RED("exposureMax")] public curveData<CFloat> ExposureMax { get; set; }
		[Ordinal(10)] [RED("exposureCenterImportance")] public curveData<CFloat> ExposureCenterImportance { get; set; }
		[Ordinal(11)] [RED("cameraVelocityFaloff")] public CFloat CameraVelocityFaloff { get; set; }

		public ExposureAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
