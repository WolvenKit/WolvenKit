using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationData : CVariable
	{
		[Ordinal(0)] [RED("time")] public CFloat Time { get; set; }
		[Ordinal(1)] [RED("widgetLibraryItemName")] public CName WidgetLibraryItemName { get; set; }
		[Ordinal(2)] [RED("introAnimation")] public CName IntroAnimation { get; set; }
		[Ordinal(3)] [RED("widgetLibraryResource")] public redResourceReferenceScriptToken WidgetLibraryResource { get; set; }
		[Ordinal(4)] [RED("notificationData")] public CHandle<gameuiGenericNotificationViewData> NotificationData { get; set; }

		public gameuiGenericNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
