using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CallActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(0)]  [RED("callingAnimName")] public CName CallingAnimName { get; set; }
		[Ordinal(1)]  [RED("status")] public CEnum<IntercomStatus> Status { get; set; }
		[Ordinal(2)]  [RED("statusText")] public inkTextWidgetReference StatusText { get; set; }
		[Ordinal(3)]  [RED("talkingAnimName")] public CName TalkingAnimName { get; set; }

		public CallActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
