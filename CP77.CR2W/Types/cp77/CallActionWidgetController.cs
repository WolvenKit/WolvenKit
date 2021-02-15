using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CallActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(28)] [RED("statusText")] public inkTextWidgetReference StatusText { get; set; }
		[Ordinal(29)] [RED("callingAnimName")] public CName CallingAnimName { get; set; }
		[Ordinal(30)] [RED("talkingAnimName")] public CName TalkingAnimName { get; set; }
		[Ordinal(31)] [RED("status")] public CEnum<IntercomStatus> Status { get; set; }

		public CallActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
