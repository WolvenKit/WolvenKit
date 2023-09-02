using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipEvolutionModule : ItemTooltipModuleController
	{
		[Ordinal(4)] 
		[RED("weaponEvolutionIcon")] 
		public inkImageWidgetReference WeaponEvolutionIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("weaponEvolutionName")] 
		public inkTextWidgetReference WeaponEvolutionName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("weaponEvolutionDescription")] 
		public inkTextWidgetReference WeaponEvolutionDescription
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ItemTooltipEvolutionModule()
		{
			WeaponEvolutionIcon = new inkImageWidgetReference();
			WeaponEvolutionName = new inkTextWidgetReference();
			WeaponEvolutionDescription = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
