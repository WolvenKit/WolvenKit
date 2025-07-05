using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hudButtonReminderGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("Button1")] 
		public inkCompoundWidgetReference Button1
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("Button2")] 
		public inkCompoundWidgetReference Button2
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("Button3")] 
		public inkCompoundWidgetReference Button3
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("uiHudButtonHelpBB")] 
		public CWeakHandle<gameIBlackboard> UiHudButtonHelpBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(13)] 
		[RED("interactingWithDeviceBBID")] 
		public CHandle<redCallbackObject> InteractingWithDeviceBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("OnRedrawText_1Callback")] 
		public CHandle<redCallbackObject> OnRedrawText_1Callback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("OnRedrawIcon_1Callback")] 
		public CHandle<redCallbackObject> OnRedrawIcon_1Callback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("OnRedrawText_2Callback")] 
		public CHandle<redCallbackObject> OnRedrawText_2Callback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("OnRedrawIcon_2Callback")] 
		public CHandle<redCallbackObject> OnRedrawIcon_2Callback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("OnRedrawText_3Callback")] 
		public CHandle<redCallbackObject> OnRedrawText_3Callback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("OnRedrawIcon_3Callback")] 
		public CHandle<redCallbackObject> OnRedrawIcon_3Callback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public hudButtonReminderGameController()
		{
			Button1 = new inkCompoundWidgetReference();
			Button2 = new inkCompoundWidgetReference();
			Button3 = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
