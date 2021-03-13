using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleLightComponent : gameLightComponent
	{
		[Ordinal(69)] [RED("allowSeparateEmissiveColor")] public CBool AllowSeparateEmissiveColor { get; set; }
		[Ordinal(70)] [RED("emissiveColor")] public CColor EmissiveColor { get; set; }
		[Ordinal(71)] [RED("lightType")] public CEnum<vehicleELightType> LightType { get; set; }
		[Ordinal(72)] [RED("highBeamPitchAngle")] public CFloat HighBeamPitchAngle { get; set; }
		[Ordinal(73)] [RED("highBeamRadiusMultiplier")] public CFloat HighBeamRadiusMultiplier { get; set; }
		[Ordinal(74)] [RED("highBeamConeMultiplier")] public CFloat HighBeamConeMultiplier { get; set; }

		public vehicleLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
