using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationSaveData : gameuiBaseUIData
	{
		[Ordinal(1)] [RED("notificationsData")] public CArray<gameuiGenericNotificationData> NotificationsData { get; set; }

		public gameuiGenericNotificationSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
