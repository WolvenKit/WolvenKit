using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NextPreviousActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(29)] 
		[RED("defaultContainer")] 
		public inkWidgetReference DefaultContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("declineContainer")] 
		public inkWidgetReference DeclineContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("moneyStatusAnimName")] 
		public CName MoneyStatusAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(32)] 
		[RED("isProcessing")] 
		public CBool IsProcessing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NextPreviousActionWidgetController()
		{
			DefaultContainer = new inkWidgetReference();
			DeclineContainer = new inkWidgetReference();
			MoneyStatusAnimName = "no_money";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
