using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("dotIndicator")] public inkWidgetReference DotIndicator { get; set; }
		[Ordinal(1)]  [RED("modAbilitiesContainer")] public inkCompoundWidgetReference ModAbilitiesContainer { get; set; }
		[Ordinal(2)]  [RED("partIndicatorController")] public CHandle<InventoryItemPartDisplay> PartIndicatorController { get; set; }

		public ItemTooltipModController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
