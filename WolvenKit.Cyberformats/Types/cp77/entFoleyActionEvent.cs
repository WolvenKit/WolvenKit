using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entFoleyActionEvent : redEvent
	{
		[Ordinal(0)] [RED("actionName")] public CName ActionName { get; set; }

		public entFoleyActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
