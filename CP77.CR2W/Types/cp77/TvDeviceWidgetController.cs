using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TvDeviceWidgetController : DeviceWidgetControllerBase
	{
		[Ordinal(10)] [RED("videoWidget")] public inkVideoWidgetReference VideoWidget { get; set; }
		[Ordinal(11)] [RED("globalTVChannelSlot")] public inkBasePanelWidgetReference GlobalTVChannelSlot { get; set; }
		[Ordinal(12)] [RED("messegeWidget")] public inkTextWidgetReference MessegeWidget { get; set; }
		[Ordinal(13)] [RED("messageBackgroundWidget")] public inkLeafWidgetReference MessageBackgroundWidget { get; set; }
		[Ordinal(14)] [RED("globalTVChannel")] public wCHandle<inkWidget> GlobalTVChannel { get; set; }
		[Ordinal(15)] [RED("activeVideo")] public redResourceReferenceScriptToken ActiveVideo { get; set; }

		public TvDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
