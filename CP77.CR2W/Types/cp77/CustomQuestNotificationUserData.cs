using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CustomQuestNotificationUserData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("data")] public questCustomQuestNotificationData Data { get; set; }

		public CustomQuestNotificationUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
