using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipEvolutionModule : ItemTooltipModuleController
	{
		[Ordinal(0)]  [RED("weaponEvolutionDescription")] public inkTextWidgetReference WeaponEvolutionDescription { get; set; }
		[Ordinal(1)]  [RED("weaponEvolutionIcon")] public inkImageWidgetReference WeaponEvolutionIcon { get; set; }
		[Ordinal(2)]  [RED("weaponEvolutionName")] public inkTextWidgetReference WeaponEvolutionName { get; set; }

		public ItemTooltipEvolutionModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
