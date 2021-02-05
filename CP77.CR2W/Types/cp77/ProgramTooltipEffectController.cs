using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProgramTooltipEffectController : ItemTooltipModController
	{
		[Ordinal(0)]  [RED("dotIndicator")] public inkWidgetReference DotIndicator { get; set; }
		[Ordinal(1)]  [RED("modAbilitiesContainer")] public inkCompoundWidgetReference ModAbilitiesContainer { get; set; }
		[Ordinal(2)]  [RED("partIndicatorController")] public CHandle<InventoryItemPartDisplay> PartIndicatorController { get; set; }

		public ProgramTooltipEffectController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
