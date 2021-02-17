using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VisibilitySimpleControllerBase : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("affectedWidgets")] public CArray<CName> AffectedWidgets { get; set; }
		[Ordinal(2)] [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(3)] [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }

		public VisibilitySimpleControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
