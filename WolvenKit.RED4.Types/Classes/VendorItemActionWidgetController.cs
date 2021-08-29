using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorItemActionWidgetController : DeviceActionWidgetControllerBase
	{
		private inkTextWidgetReference _priceWidget;
		private inkWidgetReference _priceContainer;
		private inkWidgetReference _moneyStatusContainer;
		private inkWidgetReference _processingStatusContainer;

		[Ordinal(29)] 
		[RED("priceWidget")] 
		public inkTextWidgetReference PriceWidget
		{
			get => GetProperty(ref _priceWidget);
			set => SetProperty(ref _priceWidget, value);
		}

		[Ordinal(30)] 
		[RED("priceContainer")] 
		public inkWidgetReference PriceContainer
		{
			get => GetProperty(ref _priceContainer);
			set => SetProperty(ref _priceContainer, value);
		}

		[Ordinal(31)] 
		[RED("moneyStatusContainer")] 
		public inkWidgetReference MoneyStatusContainer
		{
			get => GetProperty(ref _moneyStatusContainer);
			set => SetProperty(ref _moneyStatusContainer, value);
		}

		[Ordinal(32)] 
		[RED("processingStatusContainer")] 
		public inkWidgetReference ProcessingStatusContainer
		{
			get => GetProperty(ref _processingStatusContainer);
			set => SetProperty(ref _processingStatusContainer, value);
		}
	}
}
