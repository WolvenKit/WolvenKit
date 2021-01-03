using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InteractiveSignDeviceWidgetController : DeviceWidgetControllerBase
	{
		[Ordinal(0)]  [RED("backgroundWidget")] public wCHandle<inkWidget> BackgroundWidget { get; set; }
		[Ordinal(1)]  [RED("backgroundWidgetPath")] public CName BackgroundWidgetPath { get; set; }
		[Ordinal(2)]  [RED("messageWidget")] public wCHandle<inkTextWidget> MessageWidget { get; set; }
		[Ordinal(3)]  [RED("messageWidgetPath")] public CName MessageWidgetPath { get; set; }

		public InteractiveSignDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
