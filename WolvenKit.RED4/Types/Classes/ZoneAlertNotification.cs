using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ZoneAlertNotification : GenericNotificationController
	{
		[Ordinal(12)] 
		[RED("animation")] 
		public CHandle<inkanimProxy> Animation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(13)] 
		[RED("zone_data")] 
		public CHandle<ZoneAlertNotificationViewData> Zone_data
		{
			get => GetPropertyValue<CHandle<ZoneAlertNotificationViewData>>();
			set => SetPropertyValue<CHandle<ZoneAlertNotificationViewData>>(value);
		}

		[Ordinal(14)] 
		[RED("ZoneLabelText")] 
		public inkTextWidgetReference ZoneLabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ZoneAlertNotification()
		{
			ZoneLabelText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
