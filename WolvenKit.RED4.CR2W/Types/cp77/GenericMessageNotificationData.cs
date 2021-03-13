using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotificationData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("identifier")] public CInt32 Identifier { get; set; }
		[Ordinal(7)] [RED("type")] public CEnum<GenericMessageNotificationType> Type { get; set; }
		[Ordinal(8)] [RED("title")] public CString Title { get; set; }
		[Ordinal(9)] [RED("message")] public CString Message { get; set; }

		public GenericMessageNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
