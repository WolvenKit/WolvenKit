using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerHintInkGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("messegeWidget")] 
		public CWeakHandle<inkTextWidget> MessegeWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("OnShowMessegeCallback")] 
		public CHandle<redCallbackObject> OnShowMessegeCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("OnMessegeUpdateCallback")] 
		public CHandle<redCallbackObject> OnMessegeUpdateCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("OnVisionModeChangedCallback")] 
		public CHandle<redCallbackObject> OnVisionModeChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public ScannerHintInkGameController()
		{
			IconWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
