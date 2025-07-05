using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiFPSCounterGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("counterWidget")] 
		public inkTextWidgetReference CounterWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public gameuiFPSCounterGameController()
		{
			CounterWidget = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
