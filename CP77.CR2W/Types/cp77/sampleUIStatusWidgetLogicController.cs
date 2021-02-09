using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleUIStatusWidgetLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("enableStateColor")] public CColor EnableStateColor { get; set; }
		[Ordinal(1)]  [RED("disableStateColor")] public CColor DisableStateColor { get; set; }
		[Ordinal(2)]  [RED("textWidget")] public wCHandle<inkTextWidget> TextWidget { get; set; }
		[Ordinal(3)]  [RED("iconWidget")] public wCHandle<inkRectangleWidget> IconWidget { get; set; }

		public sampleUIStatusWidgetLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
