using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTimeDisplayLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("timerText")] 
		public inkTextWidgetReference TimerText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("noConnectionText")] 
		public inkTextWidgetReference NoConnectionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public gameuiTimeDisplayLogicController()
		{
			TimerText = new();
			NoConnectionText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
