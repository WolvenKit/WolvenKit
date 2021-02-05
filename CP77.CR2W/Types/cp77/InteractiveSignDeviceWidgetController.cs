using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractiveSignDeviceWidgetController : DeviceWidgetControllerBase
	{
		[Ordinal(9)]  [RED("messageWidgetPath")] public CName MessageWidgetPath { get; set; }
		[Ordinal(10)]  [RED("backgroundWidgetPath")] public CName BackgroundWidgetPath { get; set; }
		[Ordinal(11)]  [RED("messageWidget")] public wCHandle<inkTextWidget> MessageWidget { get; set; }
		[Ordinal(12)]  [RED("backgroundWidget")] public wCHandle<inkWidget> BackgroundWidget { get; set; }

		public InteractiveSignDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
