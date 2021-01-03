using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipRecipeDataModule : ItemTooltipModuleController
	{
		[Ordinal(0)]  [RED("damageTypesContainer")] public inkCompoundWidgetReference DamageTypesContainer { get; set; }
		[Ordinal(1)]  [RED("damageTypesLabel")] public inkTextWidgetReference DamageTypesLabel { get; set; }
		[Ordinal(2)]  [RED("damageTypesWrapper")] public inkWidgetReference DamageTypesWrapper { get; set; }
		[Ordinal(3)]  [RED("statsContainer")] public inkCompoundWidgetReference StatsContainer { get; set; }
		[Ordinal(4)]  [RED("statsLabel")] public inkTextWidgetReference StatsLabel { get; set; }
		[Ordinal(5)]  [RED("statsWrapper")] public inkWidgetReference StatsWrapper { get; set; }

		public ItemTooltipRecipeDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
