using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipEvolutionModule : ItemTooltipModuleController
	{
		[Ordinal(2)] 
		[RED("weaponEvolutionIcon")] 
		public inkImageWidgetReference WeaponEvolutionIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("weaponEvolutionName")] 
		public inkTextWidgetReference WeaponEvolutionName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("weaponEvolutionDescription")] 
		public inkTextWidgetReference WeaponEvolutionDescription
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ItemTooltipEvolutionModule()
		{
			WeaponEvolutionIcon = new();
			WeaponEvolutionName = new();
			WeaponEvolutionDescription = new();
		}
	}
}
