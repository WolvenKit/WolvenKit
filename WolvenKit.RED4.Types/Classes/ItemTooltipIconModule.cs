using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipIconModule : ItemTooltipModuleController
	{
		[Ordinal(2)] 
		[RED("container")] 
		public inkImageWidgetReference Container
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("iconicLines")] 
		public inkImageWidgetReference IconicLines
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("transmogged")] 
		public inkImageWidgetReference Transmogged
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("iconsNameResolver")] 
		public CHandle<gameuiIconsNameResolver> IconsNameResolver
		{
			get => GetPropertyValue<CHandle<gameuiIconsNameResolver>>();
			set => SetPropertyValue<CHandle<gameuiIconsNameResolver>>(value);
		}

		public ItemTooltipIconModule()
		{
			Container = new();
			Icon = new();
			IconicLines = new();
			Transmogged = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
