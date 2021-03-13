using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WaterAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("blurMin")] public CFloat BlurMin { get; set; }
		[Ordinal(3)] [RED("blurMax")] public CFloat BlurMax { get; set; }
		[Ordinal(4)] [RED("blurExponent")] public CFloat BlurExponent { get; set; }
		[Ordinal(5)] [RED("depth")] public CFloat Depth { get; set; }
		[Ordinal(6)] [RED("density")] public CFloat Density { get; set; }
		[Ordinal(7)] [RED("lightAbsorptionColor")] public HDRColor LightAbsorptionColor { get; set; }
		[Ordinal(8)] [RED("lightDecayColor")] public HDRColor LightDecayColor { get; set; }
		[Ordinal(9)] [RED("globalWaterMask")] public rRef<CBitmapTexture> GlobalWaterMask { get; set; }

		public WaterAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
