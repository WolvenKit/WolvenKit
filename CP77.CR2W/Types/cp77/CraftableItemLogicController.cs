using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CraftableItemLogicController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("normalAppearence")] public inkCompoundWidgetReference NormalAppearence { get; set; }
		[Ordinal(1)]  [RED("controller")] public wCHandle<InventoryItemDisplayController> Controller { get; set; }
		[Ordinal(2)]  [RED("isSelected")] public CBool IsSelected { get; set; }
		[Ordinal(3)]  [RED("displayToCreate")] public CName DisplayToCreate { get; set; }

		public CraftableItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
