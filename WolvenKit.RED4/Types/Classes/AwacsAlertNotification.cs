using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AwacsAlertNotification : GenericNotificationController
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
		public CHandle<VehicleAlertNotificationViewData> Zone_data
		{
			get => GetPropertyValue<CHandle<VehicleAlertNotificationViewData>>();
			set => SetPropertyValue<CHandle<VehicleAlertNotificationViewData>>(value);
		}

		[Ordinal(17)] 
		[RED("ZoneLabelText")] 
		public inkTextWidgetReference ZoneLabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public AwacsAlertNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
