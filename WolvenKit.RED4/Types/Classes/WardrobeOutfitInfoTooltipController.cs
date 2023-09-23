using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WardrobeOutfitInfoTooltipController : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		public WardrobeOutfitInfoTooltipController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
