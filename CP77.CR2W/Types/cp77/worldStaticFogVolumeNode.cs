using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStaticFogVolumeNode : worldNode
	{
		[Ordinal(0)]  [RED("absolute")] public CBool Absolute { get; set; }
		[Ordinal(1)]  [RED("absorption")] public CFloat Absorption { get; set; }
		[Ordinal(2)]  [RED("ambientScale")] public CFloat AmbientScale { get; set; }
		[Ordinal(3)]  [RED("applyHeightFalloff")] public CBool ApplyHeightFalloff { get; set; }
		[Ordinal(4)]  [RED("blendFalloff")] public CFloat BlendFalloff { get; set; }
		[Ordinal(5)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(6)]  [RED("densityFactor")] public CFloat DensityFactor { get; set; }
		[Ordinal(7)]  [RED("densityFalloff")] public CFloat DensityFalloff { get; set; }
		[Ordinal(8)]  [RED("envColorGroup")] public CEnum<EEnvColorGroup> EnvColorGroup { get; set; }
		[Ordinal(9)]  [RED("lightChannels")] public CEnum<rendLightChannel> LightChannels { get; set; }
		[Ordinal(10)]  [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(11)]  [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }

		public worldStaticFogVolumeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
