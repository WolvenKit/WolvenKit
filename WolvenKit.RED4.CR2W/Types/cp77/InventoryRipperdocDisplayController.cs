using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryRipperdocDisplayController : InventoryItemDisplayController
	{
		[Ordinal(78)] [RED("ownedBackground")] public inkWidgetReference OwnedBackground { get; set; }
		[Ordinal(79)] [RED("ownedSign")] public inkWidgetReference OwnedSign { get; set; }

		public InventoryRipperdocDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
