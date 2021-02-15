using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_WorkspotItem : animAnimEvent
	{
		[Ordinal(3)] [RED("actions")] public CArray<CHandle<workIWorkspotItemAction>> Actions { get; set; }

		public animAnimEvent_WorkspotItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
