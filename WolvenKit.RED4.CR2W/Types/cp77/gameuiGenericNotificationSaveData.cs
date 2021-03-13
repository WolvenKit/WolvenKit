using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationSaveData : gameuiBaseUIData
	{
		[Ordinal(1)] [RED("notificationsData")] public CArray<gameuiGenericNotificationData> NotificationsData { get; set; }

		public gameuiGenericNotificationSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
