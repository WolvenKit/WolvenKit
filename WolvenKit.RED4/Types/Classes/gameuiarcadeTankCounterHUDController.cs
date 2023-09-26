using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeTankCounterHUDController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("counterText")] 
		public inkTextWidgetReference CounterText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public gameuiarcadeTankCounterHUDController()
		{
			CounterText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
