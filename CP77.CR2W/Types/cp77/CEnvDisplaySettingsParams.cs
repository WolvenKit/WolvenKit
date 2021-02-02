using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CEnvDisplaySettingsParams : CVariable
	{
		[Ordinal(0)]  [RED("gamma")] public CFloat Gamma { get; set; }
		[Ordinal(1)]  [RED("enableInstantAdaptation")] public CBool EnableInstantAdaptation { get; set; }
		[Ordinal(2)]  [RED("enableGlobalLightingTrajectory")] public CBool EnableGlobalLightingTrajectory { get; set; }
		[Ordinal(3)]  [RED("enableEnvProbeInstantUpdate")] public CBool EnableEnvProbeInstantUpdate { get; set; }
		[Ordinal(4)]  [RED("allowEnvProbeUpdate")] public CBool AllowEnvProbeUpdate { get; set; }
		[Ordinal(5)]  [RED("allowBloom")] public CBool AllowBloom { get; set; }
		[Ordinal(6)]  [RED("allowColorMod")] public CBool AllowColorMod { get; set; }
		[Ordinal(7)]  [RED("allowAntialiasing")] public CBool AllowAntialiasing { get; set; }
		[Ordinal(8)]  [RED("allowGlobalFog")] public CBool AllowGlobalFog { get; set; }
		[Ordinal(9)]  [RED("allowDOF")] public CBool AllowDOF { get; set; }
		[Ordinal(10)]  [RED("allowSSAO")] public CBool AllowSSAO { get; set; }
		[Ordinal(11)]  [RED("allowCloudsShadow")] public CBool AllowCloudsShadow { get; set; }
		[Ordinal(12)]  [RED("allowWaterShader")] public CBool AllowWaterShader { get; set; }

		public CEnvDisplaySettingsParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
