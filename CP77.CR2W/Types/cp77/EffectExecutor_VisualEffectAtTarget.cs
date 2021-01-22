using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_VisualEffectAtTarget : gameEffectExecutor_Scripted
	{
		[Ordinal(0)]  [RED("effect")] public gameFxResource Effect { get; set; }
		[Ordinal(1)]  [RED("ignoreTimeDilation")] public CBool IgnoreTimeDilation { get; set; }

		public EffectExecutor_VisualEffectAtTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
