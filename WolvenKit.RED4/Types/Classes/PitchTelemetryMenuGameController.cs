using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PitchTelemetryMenuGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("telemetrySelectorRef")] 
		public inkWidgetReference TelemetrySelectorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("marketing1SelectorRef")] 
		public inkWidgetReference Marketing1SelectorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("hyperlinkButtonRef")] 
		public inkWidgetReference HyperlinkButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("inputHintConsentRef")] 
		public inkTextWidgetReference InputHintConsentRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("telemetrySelectorController")] 
		public CWeakHandle<PitchSelectorControllerBool> TelemetrySelectorController
		{
			get => GetPropertyValue<CWeakHandle<PitchSelectorControllerBool>>();
			set => SetPropertyValue<CWeakHandle<PitchSelectorControllerBool>>(value);
		}

		[Ordinal(8)] 
		[RED("marketing1SelectorController")] 
		public CWeakHandle<PitchSelectorControllerBool> Marketing1SelectorController
		{
			get => GetPropertyValue<CWeakHandle<PitchSelectorControllerBool>>();
			set => SetPropertyValue<CWeakHandle<PitchSelectorControllerBool>>(value);
		}

		[Ordinal(9)] 
		[RED("eventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(10)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(11)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(12)] 
		[RED("shouldConsentToAll")] 
		public CBool ShouldConsentToAll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PitchTelemetryMenuGameController()
		{
			TelemetrySelectorRef = new inkWidgetReference();
			Marketing1SelectorRef = new inkWidgetReference();
			HyperlinkButtonRef = new inkWidgetReference();
			InputHintConsentRef = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
