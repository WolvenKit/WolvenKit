using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RTAOAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("RangeNear")] public curveData<CFloat> RangeNear { get; set; }
		[Ordinal(3)] [RED("RangeFar")] public curveData<CFloat> RangeFar { get; set; }
		[Ordinal(4)] [RED("RadiusNear")] public curveData<CFloat> RadiusNear { get; set; }
		[Ordinal(5)] [RED("RadiusFar")] public curveData<CFloat> RadiusFar { get; set; }
		[Ordinal(6)] [RED("coneAoDiffuseStrength")] public curveData<CFloat> ConeAoDiffuseStrength { get; set; }
		[Ordinal(7)] [RED("coneAoSpecularStrength")] public curveData<CFloat> ConeAoSpecularStrength { get; set; }
		[Ordinal(8)] [RED("coneAoSpecularTreshold")] public curveData<CFloat> ConeAoSpecularTreshold { get; set; }
		[Ordinal(9)] [RED("lightAoDiffuseStrength")] public curveData<CFloat> LightAoDiffuseStrength { get; set; }
		[Ordinal(10)] [RED("lightAoSpecularStrength")] public curveData<CFloat> LightAoSpecularStrength { get; set; }

		public RTAOAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
