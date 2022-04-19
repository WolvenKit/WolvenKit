using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArcadeMachineInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("defaultUI")] 
		public CWeakHandle<inkCanvasWidget> DefaultUI
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(17)] 
		[RED("mainDisplayWidget")] 
		public CWeakHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(18)] 
		[RED("counterWidget")] 
		public CWeakHandle<inkTextWidget> CounterWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public ArcadeMachineInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
