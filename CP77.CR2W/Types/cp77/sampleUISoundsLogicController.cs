using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleUISoundsLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("textWidget")] public wCHandle<inkTextWidget> TextWidget { get; set; }

		public sampleUISoundsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
