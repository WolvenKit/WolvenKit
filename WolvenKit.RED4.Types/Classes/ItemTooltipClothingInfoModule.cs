using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipClothingInfoModule : ItemTooltipModuleController
	{
		[Ordinal(2)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public ItemTooltipClothingInfoModule()
		{
			Value = new();
			Arrow = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
