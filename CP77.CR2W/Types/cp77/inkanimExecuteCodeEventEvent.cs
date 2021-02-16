using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimExecuteCodeEventEvent : inkanimEvent
	{
		[Ordinal(1)] [RED("eventToExecute")] public CHandle<redEvent> EventToExecute { get; set; }

		public inkanimExecuteCodeEventEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
