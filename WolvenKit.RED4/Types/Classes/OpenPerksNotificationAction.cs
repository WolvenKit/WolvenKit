using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpenPerksNotificationAction : GenericNotificationBaseAction
	{
		[Ordinal(0)] 
		[RED("eventDispatcher")] 
		public CWeakHandle<worlduiIWidgetGameController> EventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<worlduiIWidgetGameController>>();
			set => SetPropertyValue<CWeakHandle<worlduiIWidgetGameController>>(value);
		}

		public OpenPerksNotificationAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
