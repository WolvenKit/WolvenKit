using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationData : CVariable
	{
		[Ordinal(0)]  [RED("introAnimation")] public CName IntroAnimation { get; set; }
		[Ordinal(1)]  [RED("notificationData")] public CHandle<gameuiGenericNotificationViewData> NotificationData { get; set; }
		[Ordinal(2)]  [RED("time")] public CFloat Time { get; set; }
		[Ordinal(3)]  [RED("widgetLibraryItemName")] public CName WidgetLibraryItemName { get; set; }
		[Ordinal(4)]  [RED("widgetLibraryResource")] public redResourceReferenceScriptToken WidgetLibraryResource { get; set; }

		public gameuiGenericNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
