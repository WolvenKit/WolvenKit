using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipEvolutionModule : ItemTooltipModuleController
	{
		[Ordinal(2)] [RED("weaponEvolutionIcon")] public inkImageWidgetReference WeaponEvolutionIcon { get; set; }
		[Ordinal(3)] [RED("weaponEvolutionName")] public inkTextWidgetReference WeaponEvolutionName { get; set; }
		[Ordinal(4)] [RED("weaponEvolutionDescription")] public inkTextWidgetReference WeaponEvolutionDescription { get; set; }

		public ItemTooltipEvolutionModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
