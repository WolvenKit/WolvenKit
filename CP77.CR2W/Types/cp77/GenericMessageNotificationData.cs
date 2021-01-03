using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
