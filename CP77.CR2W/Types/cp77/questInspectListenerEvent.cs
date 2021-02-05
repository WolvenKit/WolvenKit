using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questInspectListenerEvent : redEvent
	{
		[Ordinal(0)]  [RED("register")] public CBool Register_ { get; set; }
		[Ordinal(1)]  [RED("listener")] public CHandle<questObjectInspectListener> Listener { get; set; }

		public questInspectListenerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
