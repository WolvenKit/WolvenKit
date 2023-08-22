using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTrialPeriodTimerController : inkGenericSystemNotificationLogicController
	{
		[Ordinal(9)] 
		[RED("timerText")] 
		public inkTextWidgetReference TimerText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public gameuiTrialPeriodTimerController()
		{
			TimerText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
