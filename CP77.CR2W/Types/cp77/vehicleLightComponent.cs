using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleLightComponent : gameLightComponent
	{
		[Ordinal(0)]  [RED("allowSeparateEmissiveColor")] public CBool AllowSeparateEmissiveColor { get; set; }
		[Ordinal(1)]  [RED("emissiveColor")] public CColor EmissiveColor { get; set; }
		[Ordinal(2)]  [RED("highBeamConeMultiplier")] public CFloat HighBeamConeMultiplier { get; set; }
		[Ordinal(3)]  [RED("highBeamPitchAngle")] public CFloat HighBeamPitchAngle { get; set; }
		[Ordinal(4)]  [RED("highBeamRadiusMultiplier")] public CFloat HighBeamRadiusMultiplier { get; set; }
		[Ordinal(5)]  [RED("lightType")] public CEnum<vehicleELightType> LightType { get; set; }

		public vehicleLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
