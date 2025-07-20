using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class YaibaShowroomConnectionPage : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("connectionFact")] 
		public CName ConnectionFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("connectionButton")] 
		public inkWidgetReference ConnectionButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public YaibaShowroomConnectionPage()
		{
			ConnectionFact = "mq060_muramasa_connected";
			ConnectionButton = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
