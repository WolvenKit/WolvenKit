using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipIconModule : ItemTooltipModuleController
	{
		[Ordinal(5)] 
		[RED("container")] 
		public inkImageWidgetReference Container
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("iconicLines")] 
		public inkImageWidgetReference IconicLines
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("transmogged")] 
		public inkImageWidgetReference Transmogged
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("iconsNameResolver")] 
		public CHandle<gameuiIconsNameResolver> IconsNameResolver
		{
			get => GetPropertyValue<CHandle<gameuiIconsNameResolver>>();
			set => SetPropertyValue<CHandle<gameuiIconsNameResolver>>(value);
		}

		public ItemTooltipIconModule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
