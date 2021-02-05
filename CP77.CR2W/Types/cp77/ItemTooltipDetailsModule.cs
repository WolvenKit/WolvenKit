using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipDetailsModule : ItemTooltipModuleController
	{
		[Ordinal(1)]  [RED("statsLine")] public inkWidgetReference StatsLine { get; set; }
		[Ordinal(2)]  [RED("statsWrapper")] public inkWidgetReference StatsWrapper { get; set; }
		[Ordinal(3)]  [RED("statsContainer")] public inkCompoundWidgetReference StatsContainer { get; set; }
		[Ordinal(4)]  [RED("dedicatedModsLine")] public inkWidgetReference DedicatedModsLine { get; set; }
		[Ordinal(5)]  [RED("dedicatedModsWrapper")] public inkWidgetReference DedicatedModsWrapper { get; set; }
		[Ordinal(6)]  [RED("dedicatedModsContainer")] public inkCompoundWidgetReference DedicatedModsContainer { get; set; }
		[Ordinal(7)]  [RED("modsLine")] public inkWidgetReference ModsLine { get; set; }
		[Ordinal(8)]  [RED("modsWrapper")] public inkWidgetReference ModsWrapper { get; set; }
		[Ordinal(9)]  [RED("modsContainer")] public inkCompoundWidgetReference ModsContainer { get; set; }

		public ItemTooltipDetailsModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
