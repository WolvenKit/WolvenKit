using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TvDeviceWidgetController : DeviceWidgetControllerBase
	{
		[Ordinal(0)]  [RED("activeVideo")] public redResourceReferenceScriptToken ActiveVideo { get; set; }
		[Ordinal(1)]  [RED("globalTVChannel")] public wCHandle<inkWidget> GlobalTVChannel { get; set; }
		[Ordinal(2)]  [RED("globalTVChannelSlot")] public inkBasePanelWidgetReference GlobalTVChannelSlot { get; set; }
		[Ordinal(3)]  [RED("messageBackgroundWidget")] public inkLeafWidgetReference MessageBackgroundWidget { get; set; }
		[Ordinal(4)]  [RED("messegeWidget")] public inkTextWidgetReference MessegeWidget { get; set; }
		[Ordinal(5)]  [RED("videoWidget")] public inkVideoWidgetReference VideoWidget { get; set; }

		public TvDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
