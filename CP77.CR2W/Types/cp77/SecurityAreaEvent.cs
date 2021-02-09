using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaEvent : ActionBool
	{
		[Ordinal(22)]  [RED("securityAreaData")] public SecurityAreaData SecurityAreaData { get; set; }
		[Ordinal(23)]  [RED("whoBreached")] public wCHandle<gameObject> WhoBreached { get; set; }

		public SecurityAreaEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
