using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConfessionalInkGameController : DeviceInkGameControllerBase
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
		[RED("messegeWidget")] 
		public CWeakHandle<inkTextWidget> MessegeWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("defaultTextWidget")] 
		public CWeakHandle<inkTextWidget> DefaultTextWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(20)] 
		[RED("actionsList")] 
		public CWeakHandle<inkWidget> ActionsList
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("RunningAnimation")] 
		public CHandle<inkanimProxy> RunningAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("isConfessing")] 
		public CBool IsConfessing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("onConfessListener")] 
		public CHandle<redCallbackObject> OnConfessListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public ConfessionalInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
