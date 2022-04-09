using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractiveSignDeviceWidgetController : DeviceWidgetControllerBase
	{
		[Ordinal(10)] 
		[RED("messageWidgetPath")] 
		public CName MessageWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("backgroundWidgetPath")] 
		public CName BackgroundWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("messageWidget")] 
		public CWeakHandle<inkTextWidget> MessageWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("backgroundWidget")] 
		public CWeakHandle<inkWidget> BackgroundWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public InteractiveSignDeviceWidgetController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
