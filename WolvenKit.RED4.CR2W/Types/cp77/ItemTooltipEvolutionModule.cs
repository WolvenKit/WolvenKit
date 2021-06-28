using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipEvolutionModule : ItemTooltipModuleController
	{
		private inkImageWidgetReference _weaponEvolutionIcon;
		private inkTextWidgetReference _weaponEvolutionName;
		private inkTextWidgetReference _weaponEvolutionDescription;

		[Ordinal(2)] 
		[RED("weaponEvolutionIcon")] 
		public inkImageWidgetReference WeaponEvolutionIcon
		{
			get => GetProperty(ref _weaponEvolutionIcon);
			set => SetProperty(ref _weaponEvolutionIcon, value);
		}

		[Ordinal(3)] 
		[RED("weaponEvolutionName")] 
		public inkTextWidgetReference WeaponEvolutionName
		{
			get => GetProperty(ref _weaponEvolutionName);
			set => SetProperty(ref _weaponEvolutionName, value);
		}

		[Ordinal(4)] 
		[RED("weaponEvolutionDescription")] 
		public inkTextWidgetReference WeaponEvolutionDescription
		{
			get => GetProperty(ref _weaponEvolutionDescription);
			set => SetProperty(ref _weaponEvolutionDescription, value);
		}

		public ItemTooltipEvolutionModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
