using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerHintInkGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("messegeWidget")] public wCHandle<inkTextWidget> MessegeWidget { get; set; }
		[Ordinal(3)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(4)] [RED("iconWidget")] public inkImageWidgetReference IconWidget { get; set; }

		public ScannerHintInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
