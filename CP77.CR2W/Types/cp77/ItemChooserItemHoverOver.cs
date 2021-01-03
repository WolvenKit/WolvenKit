using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemChooserItemHoverOver : redEvent
	{
		[Ordinal(0)]  [RED("sourceEvent")] public CHandle<inkPointerEvent> SourceEvent { get; set; }
		[Ordinal(1)]  [RED("targetItem")] public wCHandle<InventoryItemDisplayController> TargetItem { get; set; }

		public ItemChooserItemHoverOver(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
