using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AINPCCommandEvent : AIAIEvent
	{
		[Ordinal(2)] [RED("command")] public CHandle<AICommand> Command { get; set; }

		public AINPCCommandEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
