using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VolumetricFogAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("albedo")] public curveData<HDRColor> Albedo { get; set; }
		[Ordinal(3)] [RED("range")] public curveData<CFloat> Range { get; set; }
		[Ordinal(4)] [RED("fogHeight")] public curveData<CFloat> FogHeight { get; set; }
		[Ordinal(5)] [RED("fogHeightFalloff")] public curveData<CFloat> FogHeightFalloff { get; set; }
		[Ordinal(6)] [RED("fogHeightMaxCut")] public curveData<CFloat> FogHeightMaxCut { get; set; }
		[Ordinal(7)] [RED("density")] public curveData<CFloat> Density { get; set; }
		[Ordinal(8)] [RED("absorption")] public curveData<CFloat> Absorption { get; set; }
		[Ordinal(9)] [RED("ambientScale")] public curveData<CFloat> AmbientScale { get; set; }
		[Ordinal(10)] [RED("localAmbientScale")] public curveData<CFloat> LocalAmbientScale { get; set; }
		[Ordinal(11)] [RED("globalLightScale")] public curveData<CFloat> GlobalLightScale { get; set; }
		[Ordinal(12)] [RED("globalLightAnisotropy")] public curveData<CFloat> GlobalLightAnisotropy { get; set; }
		[Ordinal(13)] [RED("globalLightAnisotropyBase")] public curveData<CFloat> GlobalLightAnisotropyBase { get; set; }
		[Ordinal(14)] [RED("globalLightAnisotropyScale")] public curveData<CFloat> GlobalLightAnisotropyScale { get; set; }
		[Ordinal(15)] [RED("localLightRange")] public curveData<CFloat> LocalLightRange { get; set; }
		[Ordinal(16)] [RED("localLightScale")] public curveData<CFloat> LocalLightScale { get; set; }
		[Ordinal(17)] [RED("distantAlbedo")] public curveData<HDRColor> DistantAlbedo { get; set; }
		[Ordinal(18)] [RED("distantGlobalLightScale")] public curveData<CFloat> DistantGlobalLightScale { get; set; }
		[Ordinal(19)] [RED("distantGroundIrradiance")] public curveData<CFloat> DistantGroundIrradiance { get; set; }
		[Ordinal(20)] [RED("distantGroundSaturation")] public curveData<CFloat> DistantGroundSaturation { get; set; }
		[Ordinal(21)] [RED("distantSkyIrradiance")] public curveData<CFloat> DistantSkyIrradiance { get; set; }
		[Ordinal(22)] [RED("distantShadowAmbientDarkening")] public curveData<CFloat> DistantShadowAmbientDarkening { get; set; }

		public VolumetricFogAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
