using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DelayPrereqEvent : redEvent
	{
		[Ordinal(0)] [RED("state")] public CHandle<GameTimePrereqState> State { get; set; }

		public DelayPrereqEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
