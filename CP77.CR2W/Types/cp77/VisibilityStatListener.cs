using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VisibilityStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public VisibilityStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
