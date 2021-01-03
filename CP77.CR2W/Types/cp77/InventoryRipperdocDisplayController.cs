using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryRipperdocDisplayController : InventoryItemDisplayController
	{
		[Ordinal(0)]  [RED("ownedBackground")] public inkWidgetReference OwnedBackground { get; set; }
		[Ordinal(1)]  [RED("ownedSign")] public inkWidgetReference OwnedSign { get; set; }

		public InventoryRipperdocDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
