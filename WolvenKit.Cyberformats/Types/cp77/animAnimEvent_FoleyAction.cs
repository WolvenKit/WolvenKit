using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FoleyAction : animAnimEvent
	{
		[Ordinal(3)] [RED("actionName")] public CName ActionName { get; set; }

		public animAnimEvent_FoleyAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
