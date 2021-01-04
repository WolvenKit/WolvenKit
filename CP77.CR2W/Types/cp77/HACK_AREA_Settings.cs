using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HACK_AREA_Settings : IAreaSettings
	{
		[Ordinal(0)]  [RED("bottomHemisphereStrength")] public CFloat BottomHemisphereStrength { get; set; }
		[Ordinal(1)]  [RED("bottomHemisphereTint")] public curveData<HDRColor> BottomHemisphereTint { get; set; }
		[Ordinal(2)]  [RED("emissiveScale")] public CFloat EmissiveScale { get; set; }
		[Ordinal(3)]  [RED("missingEnergyScale")] public CFloat MissingEnergyScale { get; set; }
		[Ordinal(4)]  [RED("overrideOnPureView")] public CBool OverrideOnPureView { get; set; }
		[Ordinal(5)]  [RED("skyScale")] public CFloat SkyScale { get; set; }
		[Ordinal(6)]  [RED("surfAlbedoOverride")] public HDRColor SurfAlbedoOverride { get; set; }
		[Ordinal(7)]  [RED("surfAlbedoOverrideRatio")] public CFloat SurfAlbedoOverrideRatio { get; set; }
		[Ordinal(8)]  [RED("surfelScale")] public CFloat SurfelScale { get; set; }

		public HACK_AREA_Settings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
