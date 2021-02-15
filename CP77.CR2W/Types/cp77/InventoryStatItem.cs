using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryStatItem : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("label")] public wCHandle<inkTextWidget> Label { get; set; }
		[Ordinal(2)] [RED("value")] public wCHandle<inkTextWidget> Value { get; set; }

		public InventoryStatItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
