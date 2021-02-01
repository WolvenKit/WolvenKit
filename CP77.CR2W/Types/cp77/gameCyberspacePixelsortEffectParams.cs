using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCyberspacePixelsortEffectParams : CVariable
	{
		[Ordinal(0)]  [RED("fullscreen")] public CBool Fullscreen { get; set; }
		[Ordinal(1)]  [RED("initialDatamosh")] public CFloat InitialDatamosh { get; set; }
		[Ordinal(2)]  [RED("initialIntensity")] public CFloat InitialIntensity { get; set; }
		[Ordinal(3)]  [RED("targetDatamosh")] public CFloat TargetDatamosh { get; set; }
		[Ordinal(4)]  [RED("targetIntensity")] public CFloat TargetIntensity { get; set; }
		[Ordinal(5)]  [RED("timeBlend")] public CFloat TimeBlend { get; set; }
		[Ordinal(6)]  [RED("vfx")] public CBool Vfx { get; set; }

		public gameCyberspacePixelsortEffectParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
