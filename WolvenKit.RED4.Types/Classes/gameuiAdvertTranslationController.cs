using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiAdvertTranslationController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("advertText")] 
		public inkTextWidgetReference AdvertText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public gameuiAdvertTranslationController()
		{
			AdvertText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
