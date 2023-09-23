using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ZoneAlertNotification : GenericNotificationController
	{
		[Ordinal(15)] 
		[RED("animation")] 
		public CHandle<inkanimProxy> Animation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(16)] 
		[RED("zone_data")] 
		public CHandle<ZoneAlertNotificationViewData> Zone_data
		{
			get => GetPropertyValue<CHandle<ZoneAlertNotificationViewData>>();
			set => SetPropertyValue<CHandle<ZoneAlertNotificationViewData>>(value);
		}

		[Ordinal(17)] 
		[RED("ZoneLabelText")] 
		public inkTextWidgetReference ZoneLabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ZoneAlertNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
