using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryItemAttachmentDisplay : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("BorderRef")] public inkWidgetReference BorderRef { get; set; }
		[Ordinal(1)]  [RED("MarkedStateName")] public CName MarkedStateName { get; set; }
		[Ordinal(2)]  [RED("QualityRootRef")] public inkWidgetReference QualityRootRef { get; set; }
		[Ordinal(3)]  [RED("ShapeRef")] public inkWidgetReference ShapeRef { get; set; }

		public InventoryItemAttachmentDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
