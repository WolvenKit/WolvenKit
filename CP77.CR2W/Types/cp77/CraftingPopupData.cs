using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CraftingPopupData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("itemTooltipData")] public CHandle<InventoryTooltipData> ItemTooltipData { get; set; }
		[Ordinal(7)] [RED("craftingCommand")] public CEnum<CraftingCommands> CraftingCommand { get; set; }

		public CraftingPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
