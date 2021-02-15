using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipRecipeDataModule : ItemTooltipModuleController
	{
		[Ordinal(2)] [RED("statsLabel")] public inkTextWidgetReference StatsLabel { get; set; }
		[Ordinal(3)] [RED("statsWrapper")] public inkWidgetReference StatsWrapper { get; set; }
		[Ordinal(4)] [RED("statsContainer")] public inkCompoundWidgetReference StatsContainer { get; set; }
		[Ordinal(5)] [RED("damageTypesLabel")] public inkTextWidgetReference DamageTypesLabel { get; set; }
		[Ordinal(6)] [RED("damageTypesWrapper")] public inkWidgetReference DamageTypesWrapper { get; set; }
		[Ordinal(7)] [RED("damageTypesContainer")] public inkCompoundWidgetReference DamageTypesContainer { get; set; }

		public ItemTooltipRecipeDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
