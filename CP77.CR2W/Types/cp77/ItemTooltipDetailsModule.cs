using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipDetailsModule : ItemTooltipModuleController
	{
		[Ordinal(0)]  [RED("dedicatedModsContainer")] public inkCompoundWidgetReference DedicatedModsContainer { get; set; }
		[Ordinal(1)]  [RED("dedicatedModsLine")] public inkWidgetReference DedicatedModsLine { get; set; }
		[Ordinal(2)]  [RED("dedicatedModsWrapper")] public inkWidgetReference DedicatedModsWrapper { get; set; }
		[Ordinal(3)]  [RED("modsContainer")] public inkCompoundWidgetReference ModsContainer { get; set; }
		[Ordinal(4)]  [RED("modsLine")] public inkWidgetReference ModsLine { get; set; }
		[Ordinal(5)]  [RED("modsWrapper")] public inkWidgetReference ModsWrapper { get; set; }
		[Ordinal(6)]  [RED("statsContainer")] public inkCompoundWidgetReference StatsContainer { get; set; }
		[Ordinal(7)]  [RED("statsLine")] public inkWidgetReference StatsLine { get; set; }
		[Ordinal(8)]  [RED("statsWrapper")] public inkWidgetReference StatsWrapper { get; set; }

		public ItemTooltipDetailsModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
