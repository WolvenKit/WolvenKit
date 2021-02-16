using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StrikeExecutor_Heal : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] [RED("healthPerc")] public CFloat HealthPerc { get; set; }

		public StrikeExecutor_Heal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
