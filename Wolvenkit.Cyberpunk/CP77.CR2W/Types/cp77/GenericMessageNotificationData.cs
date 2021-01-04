using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotificationData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("identifier")] public CInt32 Identifier { get; set; }
		[Ordinal(1)]  [RED("message")] public CString Message { get; set; }
		[Ordinal(2)]  [RED("title")] public CString Title { get; set; }
		[Ordinal(3)]  [RED("type")] public CEnum<GenericMessageNotificationType> Type { get; set; }

		public GenericMessageNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
