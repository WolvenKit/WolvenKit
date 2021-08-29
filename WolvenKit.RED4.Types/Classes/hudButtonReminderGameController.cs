using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class hudButtonReminderGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _button1;
		private inkCompoundWidgetReference _button2;
		private inkCompoundWidgetReference _button3;
		private CWeakHandle<gameIBlackboard> _uiHudButtonHelpBB;
		private CHandle<redCallbackObject> _interactingWithDeviceBBID;
		private CHandle<redCallbackObject> _onRedrawText_1Callback;
		private CHandle<redCallbackObject> _onRedrawIcon_1Callback;
		private CHandle<redCallbackObject> _onRedrawText_2Callback;
		private CHandle<redCallbackObject> _onRedrawIcon_2Callback;
		private CHandle<redCallbackObject> _onRedrawText_3Callback;
		private CHandle<redCallbackObject> _onRedrawIcon_3Callback;

		[Ordinal(9)] 
		[RED("Button1")] 
		public inkCompoundWidgetReference Button1
		{
			get => GetProperty(ref _button1);
			set => SetProperty(ref _button1, value);
		}

		[Ordinal(10)] 
		[RED("Button2")] 
		public inkCompoundWidgetReference Button2
		{
			get => GetProperty(ref _button2);
			set => SetProperty(ref _button2, value);
		}

		[Ordinal(11)] 
		[RED("Button3")] 
		public inkCompoundWidgetReference Button3
		{
			get => GetProperty(ref _button3);
			set => SetProperty(ref _button3, value);
		}

		[Ordinal(12)] 
		[RED("uiHudButtonHelpBB")] 
		public CWeakHandle<gameIBlackboard> UiHudButtonHelpBB
		{
			get => GetProperty(ref _uiHudButtonHelpBB);
			set => SetProperty(ref _uiHudButtonHelpBB, value);
		}

		[Ordinal(13)] 
		[RED("interactingWithDeviceBBID")] 
		public CHandle<redCallbackObject> InteractingWithDeviceBBID
		{
			get => GetProperty(ref _interactingWithDeviceBBID);
			set => SetProperty(ref _interactingWithDeviceBBID, value);
		}

		[Ordinal(14)] 
		[RED("OnRedrawText_1Callback")] 
		public CHandle<redCallbackObject> OnRedrawText_1Callback
		{
			get => GetProperty(ref _onRedrawText_1Callback);
			set => SetProperty(ref _onRedrawText_1Callback, value);
		}

		[Ordinal(15)] 
		[RED("OnRedrawIcon_1Callback")] 
		public CHandle<redCallbackObject> OnRedrawIcon_1Callback
		{
			get => GetProperty(ref _onRedrawIcon_1Callback);
			set => SetProperty(ref _onRedrawIcon_1Callback, value);
		}

		[Ordinal(16)] 
		[RED("OnRedrawText_2Callback")] 
		public CHandle<redCallbackObject> OnRedrawText_2Callback
		{
			get => GetProperty(ref _onRedrawText_2Callback);
			set => SetProperty(ref _onRedrawText_2Callback, value);
		}

		[Ordinal(17)] 
		[RED("OnRedrawIcon_2Callback")] 
		public CHandle<redCallbackObject> OnRedrawIcon_2Callback
		{
			get => GetProperty(ref _onRedrawIcon_2Callback);
			set => SetProperty(ref _onRedrawIcon_2Callback, value);
		}

		[Ordinal(18)] 
		[RED("OnRedrawText_3Callback")] 
		public CHandle<redCallbackObject> OnRedrawText_3Callback
		{
			get => GetProperty(ref _onRedrawText_3Callback);
			set => SetProperty(ref _onRedrawText_3Callback, value);
		}

		[Ordinal(19)] 
		[RED("OnRedrawIcon_3Callback")] 
		public CHandle<redCallbackObject> OnRedrawIcon_3Callback
		{
			get => GetProperty(ref _onRedrawIcon_3Callback);
			set => SetProperty(ref _onRedrawIcon_3Callback, value);
		}
	}
}
