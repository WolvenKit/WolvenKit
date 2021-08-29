using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerHintInkGameController : gameuiWidgetGameController
	{
		private CWeakHandle<inkTextWidget> _messegeWidget;
		private CWeakHandle<inkWidget> _root;
		private inkImageWidgetReference _iconWidget;
		private CHandle<redCallbackObject> _onShowMessegeCallback;
		private CHandle<redCallbackObject> _onMessegeUpdateCallback;
		private CHandle<redCallbackObject> _onVisionModeChangedCallback;

		[Ordinal(2)] 
		[RED("messegeWidget")] 
		public CWeakHandle<inkTextWidget> MessegeWidget
		{
			get => GetProperty(ref _messegeWidget);
			set => SetProperty(ref _messegeWidget, value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(4)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get => GetProperty(ref _iconWidget);
			set => SetProperty(ref _iconWidget, value);
		}

		[Ordinal(5)] 
		[RED("OnShowMessegeCallback")] 
		public CHandle<redCallbackObject> OnShowMessegeCallback
		{
			get => GetProperty(ref _onShowMessegeCallback);
			set => SetProperty(ref _onShowMessegeCallback, value);
		}

		[Ordinal(6)] 
		[RED("OnMessegeUpdateCallback")] 
		public CHandle<redCallbackObject> OnMessegeUpdateCallback
		{
			get => GetProperty(ref _onMessegeUpdateCallback);
			set => SetProperty(ref _onMessegeUpdateCallback, value);
		}

		[Ordinal(7)] 
		[RED("OnVisionModeChangedCallback")] 
		public CHandle<redCallbackObject> OnVisionModeChangedCallback
		{
			get => GetProperty(ref _onVisionModeChangedCallback);
			set => SetProperty(ref _onVisionModeChangedCallback, value);
		}
	}
}
