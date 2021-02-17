using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsList : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("titleText")] public wCHandle<inkTextWidget> TitleText { get; set; }
		[Ordinal(2)] [RED("containerWidget")] public wCHandle<inkCompoundWidget> ContainerWidget { get; set; }
		[Ordinal(3)] [RED("widgtesList")] public CArray<wCHandle<inkWidget>> WidgtesList { get; set; }

		public InventoryStatsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
