using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PayActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(29)] 
		[RED("priceContainer")] 
		public inkWidgetReference PriceContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("moneyStatusContainer")] 
		public inkWidgetReference MoneyStatusContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("processingStatusContainer")] 
		public inkWidgetReference ProcessingStatusContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("moneyStatusAnimName")] 
		public CName MoneyStatusAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("processingAnimName")] 
		public CName ProcessingAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("isProcessingPayment")] 
		public CBool IsProcessingPayment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PayActionWidgetController()
		{
			PriceContainer = new inkWidgetReference();
			MoneyStatusContainer = new inkWidgetReference();
			ProcessingStatusContainer = new inkWidgetReference();
			MoneyStatusAnimName = "no_money";
			ProcessingAnimName = "pay";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
