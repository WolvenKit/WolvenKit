using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_PingNetwork : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] [RED("fxResource")] public gameFxResource FxResource { get; set; }

		public EffectExecutor_PingNetwork(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
