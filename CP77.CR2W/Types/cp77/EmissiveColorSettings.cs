using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EmissiveColorSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("tint")] public curveData<HDRColor> Tint { get; set; }
		[Ordinal(1)]  [RED("saturation")] public curveData<CFloat> Saturation { get; set; }
		[Ordinal(2)]  [RED("brigtness")] public curveData<CFloat> Brigtness { get; set; }
		[Ordinal(3)]  [RED("exposure")] public curveData<Vector2> Exposure { get; set; }
		[Ordinal(4)]  [RED("cameraLuminance")] public curveData<Vector2> CameraLuminance { get; set; }
		[Ordinal(5)]  [RED("evBlend")] public curveData<CFloat> EvBlend { get; set; }
		[Ordinal(6)]  [RED("exposureIBL")] public curveData<CFloat> ExposureIBL { get; set; }
		[Ordinal(7)]  [RED("luminanceIBL")] public curveData<CFloat> LuminanceIBL { get; set; }
		[Ordinal(8)]  [RED("curveRampIBL")] public CFloat CurveRampIBL { get; set; }
		[Ordinal(9)]  [RED("exposureScale")] public curveData<CFloat> ExposureScale { get; set; }

		public EmissiveColorSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
