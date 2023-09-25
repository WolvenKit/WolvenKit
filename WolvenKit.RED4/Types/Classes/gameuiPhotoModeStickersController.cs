using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhotoModeStickersController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("backgroundPrefabRef")] 
		public NodeRef BackgroundPrefabRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("ResetStickers")] 
		public inkEmptyCallback ResetStickers
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(4)] 
		[RED("SetStickerImage")] 
		public gameuiStickerImageCallback SetStickerImage
		{
			get => GetPropertyValue<gameuiStickerImageCallback>();
			set => SetPropertyValue<gameuiStickerImageCallback>(value);
		}

		[Ordinal(5)] 
		[RED("SetFrameImage")] 
		public gameuiStickerFrameCallback SetFrameImage
		{
			get => GetPropertyValue<gameuiStickerFrameCallback>();
			set => SetPropertyValue<gameuiStickerFrameCallback>(value);
		}

		[Ordinal(6)] 
		[RED("SetBackground")] 
		public gameuiStickerBackgroundCallback SetBackground
		{
			get => GetPropertyValue<gameuiStickerBackgroundCallback>();
			set => SetPropertyValue<gameuiStickerBackgroundCallback>(value);
		}

		[Ordinal(7)] 
		[RED("SetSetSelectedSticker")] 
		public gameuiStickerCallback SetSetSelectedSticker
		{
			get => GetPropertyValue<gameuiStickerCallback>();
			set => SetPropertyValue<gameuiStickerCallback>(value);
		}

		[Ordinal(8)] 
		[RED("stickerLibraryId")] 
		public CName StickerLibraryId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("stickersRoot")] 
		public inkWidgetReference StickersRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("frameRoot")] 
		public inkWidgetReference FrameRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("backgroundViewRoot")] 
		public inkWidgetReference BackgroundViewRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("stickers")] 
		public CArray<CWeakHandle<inkWidget>> Stickers
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(13)] 
		[RED("frame")] 
		public CWeakHandle<inkWidget> Frame
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(14)] 
		[RED("frameLogic")] 
		public CWeakHandle<PhotoModeFrame> FrameLogic
		{
			get => GetPropertyValue<CWeakHandle<PhotoModeFrame>>();
			set => SetPropertyValue<CWeakHandle<PhotoModeFrame>>(value);
		}

		[Ordinal(15)] 
		[RED("currentHovered")] 
		public CInt32 CurrentHovered
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("currentMouseDrag")] 
		public CInt32 CurrentMouseDrag
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("currentMouseRotate")] 
		public CInt32 CurrentMouseRotate
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("stickerDragStartRotation")] 
		public CFloat StickerDragStartRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("stickerDragStartScale")] 
		public Vector2 StickerDragStartScale
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(20)] 
		[RED("stickerDragStartPos")] 
		public Vector2 StickerDragStartPos
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(21)] 
		[RED("mouseDragStartPos")] 
		public Vector2 MouseDragStartPos
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(22)] 
		[RED("mouseDragCurrentPos")] 
		public Vector2 MouseDragCurrentPos
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(23)] 
		[RED("currentSticker")] 
		public CInt32 CurrentSticker
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("stickerMove")] 
		public Vector2 StickerMove
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(25)] 
		[RED("stickerRotation")] 
		public CFloat StickerRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("stickerScale")] 
		public CFloat StickerScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("stickersAreaSize")] 
		public Vector2 StickersAreaSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(28)] 
		[RED("cursorInputEnabled")] 
		public CBool CursorInputEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("editorEnabled")] 
		public CBool EditorEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("root")] 
		public CWeakHandle<inkCanvasWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(31)] 
		[RED("isInPhotoMode")] 
		public CBool IsInPhotoMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiPhotoModeStickersController()
		{
			ResetStickers = new inkEmptyCallback();
			SetStickerImage = new gameuiStickerImageCallback();
			SetFrameImage = new gameuiStickerFrameCallback();
			SetBackground = new gameuiStickerBackgroundCallback();
			SetSetSelectedSticker = new gameuiStickerCallback();
			StickersRoot = new inkWidgetReference();
			FrameRoot = new inkWidgetReference();
			BackgroundViewRoot = new inkWidgetReference();
			Stickers = new();
			StickerDragStartScale = new Vector2();
			StickerDragStartPos = new Vector2();
			MouseDragStartPos = new Vector2();
			MouseDragCurrentPos = new Vector2();
			StickerMove = new Vector2();
			StickersAreaSize = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
