using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MasterDeviceInkGameControllerBase : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("thumbnailWidgetsData")] 
		public CArray<SThumbnailWidgetPackage> ThumbnailWidgetsData
		{
			get => GetPropertyValue<CArray<SThumbnailWidgetPackage>>();
			set => SetPropertyValue<CArray<SThumbnailWidgetPackage>>(value);
		}

		[Ordinal(17)] 
		[RED("onThumbnailWidgetsUpdateListener")] 
		public CHandle<redCallbackObject> OnThumbnailWidgetsUpdateListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("onCleanPasswordListener")] 
		public CHandle<redCallbackObject> OnCleanPasswordListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("keypadController")] 
		public CWeakHandle<KeypadDeviceController> KeypadController
		{
			get => GetPropertyValue<CWeakHandle<KeypadDeviceController>>();
			set => SetPropertyValue<CWeakHandle<KeypadDeviceController>>(value);
		}

		public MasterDeviceInkGameControllerBase()
		{
			ThumbnailWidgetsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
