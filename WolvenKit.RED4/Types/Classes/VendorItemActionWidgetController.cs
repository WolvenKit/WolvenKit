using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorItemActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(29)] 
		[RED("priceWidget")] 
		public inkTextWidgetReference PriceWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("priceContainer")] 
		public inkWidgetReference PriceContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("moneyStatusContainer")] 
		public inkWidgetReference MoneyStatusContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("processingStatusContainer")] 
		public inkWidgetReference ProcessingStatusContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public VendorItemActionWidgetController()
		{
			PriceWidget = new();
			PriceContainer = new();
			MoneyStatusContainer = new();
			ProcessingStatusContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
