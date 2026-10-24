using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGenericNotificationReceiverGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("ItemChanged")] 
		public inkEmptyCallback ItemChanged
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(3)] 
		[RED("NotificationPaused")] 
		public inkEmptyCallback NotificationPaused
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(4)] 
		[RED("NotificationResumed")] 
		public inkEmptyCallback NotificationResumed
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		public gameuiGenericNotificationReceiverGameController()
		{
			ItemChanged = new inkEmptyCallback { CallbackName = "OnItemChanged" };
			NotificationPaused = new inkEmptyCallback { CallbackName = "OnNotificationPaused" };
			NotificationResumed = new inkEmptyCallback { CallbackName = "OnNotificationResumed" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
