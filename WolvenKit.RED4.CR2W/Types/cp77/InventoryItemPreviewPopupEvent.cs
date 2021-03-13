using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemPreviewPopupEvent : redEvent
	{
		[Ordinal(0)] [RED("data")] public CHandle<InventoryItemPreviewData> Data { get; set; }

		public InventoryItemPreviewPopupEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
