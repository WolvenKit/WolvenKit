using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsList : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("containerWidget")] public wCHandle<inkCompoundWidget> ContainerWidget { get; set; }
		[Ordinal(1)]  [RED("titleText")] public wCHandle<inkTextWidget> TitleText { get; set; }
		[Ordinal(2)]  [RED("widgtesList")] public CArray<wCHandle<inkWidget>> WidgtesList { get; set; }

		public InventoryStatsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
