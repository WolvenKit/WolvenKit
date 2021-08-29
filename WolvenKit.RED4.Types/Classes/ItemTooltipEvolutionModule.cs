using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipEvolutionModule : ItemTooltipModuleController
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
	}
}
