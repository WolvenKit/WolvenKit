using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FrameSwitcherMenuGameController : GalleryMenuGameController
	{
		[Ordinal(39)] 
		[RED("frameDisplay")] 
		public inkImageWidgetReference FrameDisplay
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("frameCanvas")] 
		public inkWidgetReference FrameCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("frameWrapper")] 
		public inkWidgetReference FrameWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("defaultImageRef")] 
		public inkImageWidgetReference DefaultImageRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("adjustButtonHintsManagerRef")] 
		public inkWidgetReference AdjustButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("movementGlobalScale")] 
		public CFloat MovementGlobalScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("zoomScale")] 
		public CFloat ZoomScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(46)] 
		[RED("maxZoom")] 
		public CFloat MaxZoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
		[RED("data")] 
		public CHandle<inkFrameNotificationData> Data
		{
			get => GetPropertyValue<CHandle<inkFrameNotificationData>>();
			set => SetPropertyValue<CHandle<inkFrameNotificationData>>(value);
		}

		[Ordinal(48)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(49)] 
		[RED("adjustButtonHintsController")] 
		public CWeakHandle<ButtonHints> AdjustButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(50)] 
		[RED("frameState")] 
		public CEnum<EFrameState> FrameState
		{
			get => GetPropertyValue<CEnum<EFrameState>>();
			set => SetPropertyValue<CEnum<EFrameState>>(value);
		}

		[Ordinal(51)] 
		[RED("isPressing")] 
		public CBool IsPressing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("readyToZoom")] 
		public CBool ReadyToZoom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("isHoveringScreenshot")] 
		public CBool IsHoveringScreenshot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("isHoveringFilter")] 
		public CBool IsHoveringFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("lastPressingPoint")] 
		public Vector2 LastPressingPoint
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(56)] 
		[RED("movementScale")] 
		public Vector2 MovementScale
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(57)] 
		[RED("timeDilationProfile")] 
		public CString TimeDilationProfile
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(58)] 
		[RED("lastMovementInput")] 
		public Vector2 LastMovementInput
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(59)] 
		[RED("transitionAnimproxy")] 
		public CHandle<inkanimProxy> TransitionAnimproxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public FrameSwitcherMenuGameController()
		{
			IsSecondaryActionEnabled = false;
			FrameDisplay = new inkImageWidgetReference();
			FrameCanvas = new inkWidgetReference();
			FrameWrapper = new inkWidgetReference();
			DefaultImageRef = new inkImageWidgetReference();
			AdjustButtonHintsManagerRef = new inkWidgetReference();
			MovementGlobalScale = 0.001000F;
			ZoomScale = 0.900000F;
			MaxZoom = 0.100000F;
			LastPressingPoint = new Vector2();
			MovementScale = new Vector2();
			TimeDilationProfile = "smartFrameMenu";
			LastMovementInput = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
