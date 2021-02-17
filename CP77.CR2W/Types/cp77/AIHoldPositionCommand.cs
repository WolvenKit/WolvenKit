using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIHoldPositionCommand : AIMoveCommand
	{
		[Ordinal(7)] [RED("duration")] public CFloat Duration { get; set; }

		public AIHoldPositionCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
