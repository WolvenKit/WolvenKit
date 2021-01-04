using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPhoneMessageNotificationViewData : gameuiQuestUpdateNotificationViewData
	{
		[Ordinal(0)]  [RED("contactHash")] public CInt32 ContactHash { get; set; }
		[Ordinal(1)]  [RED("threadHash")] public CInt32 ThreadHash { get; set; }

		public gameuiPhoneMessageNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
