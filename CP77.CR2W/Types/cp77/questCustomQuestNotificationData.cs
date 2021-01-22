using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCustomQuestNotificationData : CVariable
	{
		[Ordinal(0)]  [RED("desc")] public CString Desc { get; set; }
		[Ordinal(1)]  [RED("fluffHeader")] public CString FluffHeader { get; set; }
		[Ordinal(2)]  [RED("header")] public CString Header { get; set; }
		[Ordinal(3)]  [RED("icon")] public CName Icon { get; set; }

		public questCustomQuestNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
