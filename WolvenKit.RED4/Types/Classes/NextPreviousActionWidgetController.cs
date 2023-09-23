using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NextPreviousActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(32)] 
		[RED("defaultContainer")] 
		public inkWidgetReference DefaultContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("declineContainer")] 
		public inkWidgetReference DeclineContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("moneyStatusAnimName")] 
		public CName MoneyStatusAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("isProcessing")] 
		public CBool IsProcessing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NextPreviousActionWidgetController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
