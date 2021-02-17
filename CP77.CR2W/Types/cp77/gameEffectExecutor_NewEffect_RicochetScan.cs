using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_NewEffect_RicochetScan : gameEffectExecutor_NewEffect
	{
		[Ordinal(5)] [RED("box")] public Vector4 Box { get; set; }
		[Ordinal(6)] [RED("isPreview")] public CBool IsPreview { get; set; }

		public gameEffectExecutor_NewEffect_RicochetScan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
