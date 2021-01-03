using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("armorEntryController")] public wCHandle<InventoryStatsEntryController> ArmorEntryController { get; set; }
		[Ordinal(1)]  [RED("detailsButton")] public inkWidgetReference DetailsButton { get; set; }
		[Ordinal(2)]  [RED("entryContainer")] public inkCompoundWidgetReference EntryContainer { get; set; }
		[Ordinal(3)]  [RED("healthEntryController")] public wCHandle<InventoryStatsEntryController> HealthEntryController { get; set; }
		[Ordinal(4)]  [RED("staminaEntryController")] public wCHandle<InventoryStatsEntryController> StaminaEntryController { get; set; }

		public InventoryStatsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
