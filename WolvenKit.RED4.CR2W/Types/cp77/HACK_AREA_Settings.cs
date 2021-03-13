using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HACK_AREA_Settings : IAreaSettings
	{
		[Ordinal(2)] [RED("surfelScale")] public CFloat SurfelScale { get; set; }
		[Ordinal(3)] [RED("missingEnergyScale")] public CFloat MissingEnergyScale { get; set; }
		[Ordinal(4)] [RED("overrideOnPureView")] public CBool OverrideOnPureView { get; set; }
		[Ordinal(5)] [RED("surfAlbedoOverrideRatio")] public CFloat SurfAlbedoOverrideRatio { get; set; }
		[Ordinal(6)] [RED("surfAlbedoOverride")] public HDRColor SurfAlbedoOverride { get; set; }
		[Ordinal(7)] [RED("skyScale")] public CFloat SkyScale { get; set; }
		[Ordinal(8)] [RED("bottomHemisphereTint")] public curveData<HDRColor> BottomHemisphereTint { get; set; }
		[Ordinal(9)] [RED("bottomHemisphereStrength")] public CFloat BottomHemisphereStrength { get; set; }
		[Ordinal(10)] [RED("emissiveScale")] public CFloat EmissiveScale { get; set; }

		public HACK_AREA_Settings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
