using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipClothingInfoModule : ItemTooltipModuleController
	{
		[Ordinal(4)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public ItemTooltipClothingInfoModule()
		{
			Value = new inkTextWidgetReference();
			Arrow = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
