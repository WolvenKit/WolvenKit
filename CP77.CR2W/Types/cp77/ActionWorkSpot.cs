using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActionWorkSpot : ActionBool
	{
		[Ordinal(0)]  [RED("workspotTarget")] public wCHandle<gamePuppet> WorkspotTarget { get; set; }

		public ActionWorkSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
