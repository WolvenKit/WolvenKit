using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SendSpiderbotToPerformActionEvent : redEvent
	{
		[Ordinal(0)] [RED("executor")] public wCHandle<gameObject> Executor { get; set; }

		public SendSpiderbotToPerformActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
