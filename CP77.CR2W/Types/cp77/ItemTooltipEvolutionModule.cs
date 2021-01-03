using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
