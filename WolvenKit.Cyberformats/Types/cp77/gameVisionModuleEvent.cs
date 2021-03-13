using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameVisionModuleEvent : redEvent
	{
		[Ordinal(0)] [RED("changedModule")] public CName ChangedModule { get; set; }
		[Ordinal(1)] [RED("activator")] public wCHandle<gameObject> Activator { get; set; }
		[Ordinal(2)] [RED("activated")] public CBool Activated { get; set; }

		public gameVisionModuleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
