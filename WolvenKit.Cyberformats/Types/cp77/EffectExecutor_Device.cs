using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_Device : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] [RED("maxDelay")] public CFloat MaxDelay { get; set; }

		public EffectExecutor_Device(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
