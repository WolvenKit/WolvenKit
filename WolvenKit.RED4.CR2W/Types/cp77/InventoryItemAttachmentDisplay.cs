using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemAttachmentDisplay : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("QualityRootRef")] public inkWidgetReference QualityRootRef { get; set; }
		[Ordinal(2)] [RED("ShapeRef")] public inkWidgetReference ShapeRef { get; set; }
		[Ordinal(3)] [RED("BorderRef")] public inkWidgetReference BorderRef { get; set; }
		[Ordinal(4)] [RED("MarkedStateName")] public CName MarkedStateName { get; set; }

		public InventoryItemAttachmentDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
