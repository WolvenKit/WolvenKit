using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventorySlotWrapperTooltip : AGenericTooltipController
	{
		[Ordinal(0)]  [RED("itemDisplayController")] public wCHandle<InventoryItemDisplayController> ItemDisplayController { get; set; }

		public InventorySlotWrapperTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
