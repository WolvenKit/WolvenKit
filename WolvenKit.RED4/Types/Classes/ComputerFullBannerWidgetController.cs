using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerFullBannerWidgetController : ComputerBannerWidgetController
	{
		[Ordinal(12)] 
		[RED("closeButtonWidget")] 
		public inkWidgetReference CloseButtonWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public ComputerFullBannerWidgetController()
		{
			CloseButtonWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
