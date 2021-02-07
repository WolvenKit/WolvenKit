using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WaterAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("blurMin")] public CFloat BlurMin { get; set; }
		[Ordinal(1)]  [RED("blurMax")] public CFloat BlurMax { get; set; }
		[Ordinal(2)]  [RED("blurExponent")] public CFloat BlurExponent { get; set; }
		[Ordinal(3)]  [RED("depth")] public CFloat Depth { get; set; }
		[Ordinal(4)]  [RED("density")] public CFloat Density { get; set; }
		[Ordinal(5)]  [RED("lightAbsorptionColor")] public HDRColor LightAbsorptionColor { get; set; }
		[Ordinal(6)]  [RED("lightDecayColor")] public HDRColor LightDecayColor { get; set; }
		[Ordinal(7)]  [RED("globalWaterMask")] public rRef<CBitmapTexture> GlobalWaterMask { get; set; }

		public WaterAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
