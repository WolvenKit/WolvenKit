using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IntercomInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("actionsList")] 
		public inkWidgetReference ActionsList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("mainDisplayWidget")] 
		public CWeakHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(18)] 
		[RED("buttonRef")] 
		public CWeakHandle<CallActionWidgetController> ButtonRef
		{
			get => GetPropertyValue<CWeakHandle<CallActionWidgetController>>();
			set => SetPropertyValue<CWeakHandle<CallActionWidgetController>>(value);
		}

		[Ordinal(19)] 
		[RED("state")] 
		public CEnum<IntercomStatus> State
		{
			get => GetPropertyValue<CEnum<IntercomStatus>>();
			set => SetPropertyValue<CEnum<IntercomStatus>>(value);
		}

		[Ordinal(20)] 
		[RED("onUpdateStatusListener")] 
		public CHandle<redCallbackObject> OnUpdateStatusListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public IntercomInkGameController()
		{
			ActionsList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
