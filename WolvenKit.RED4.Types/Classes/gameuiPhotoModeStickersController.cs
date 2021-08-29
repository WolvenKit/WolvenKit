using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPhotoModeStickersController : gameuiWidgetGameController
	{
		private NodeRef _backgroundPrefabRef;
		private inkEmptyCallback _resetStickers;
		private gameuiStickerImageCallback _setStickerImage;
		private gameuiStickerFrameCallback _setFrameImage;
		private gameuiStickerBackgroundCallback _setBackground;
		private gameuiStickerCallback _setSetSelectedSticker;
		private CName _stickerLibraryId;
		private inkWidgetReference _stickersRoot;
		private inkWidgetReference _frameRoot;
		private inkWidgetReference _backgroundViewRoot;
		private CArray<CWeakHandle<inkWidget>> _stickers;
		private CWeakHandle<inkWidget> _frame;
		private CWeakHandle<PhotoModeFrame> _frameLogic;
		private CInt32 _currentHovered;
		private CInt32 _currentMouseDrag;
		private CInt32 _currentMouseRotate;
		private CFloat _stickerDragStartRotation;
		private Vector2 _stickerDragStartScale;
		private Vector2 _stickerDragStartPos;
		private Vector2 _mouseDragStartPos;
		private Vector2 _mouseDragCurrentPos;
		private CInt32 _currentSticker;
		private Vector2 _stickerMove;
		private CFloat _stickerRotation;
		private CFloat _stickerScale;
		private Vector2 _stickersAreaSize;
		private CBool _cursorInputEnabled;
		private CBool _editorEnabled;
		private CWeakHandle<inkCanvasWidget> _root;
		private CBool _isInPhotoMode;

		[Ordinal(2)] 
		[RED("backgroundPrefabRef")] 
		public NodeRef BackgroundPrefabRef
		{
			get => GetProperty(ref _backgroundPrefabRef);
			set => SetProperty(ref _backgroundPrefabRef, value);
		}

		[Ordinal(3)] 
		[RED("ResetStickers")] 
		public inkEmptyCallback ResetStickers
		{
			get => GetProperty(ref _resetStickers);
			set => SetProperty(ref _resetStickers, value);
		}

		[Ordinal(4)] 
		[RED("SetStickerImage")] 
		public gameuiStickerImageCallback SetStickerImage
		{
			get => GetProperty(ref _setStickerImage);
			set => SetProperty(ref _setStickerImage, value);
		}

		[Ordinal(5)] 
		[RED("SetFrameImage")] 
		public gameuiStickerFrameCallback SetFrameImage
		{
			get => GetProperty(ref _setFrameImage);
			set => SetProperty(ref _setFrameImage, value);
		}

		[Ordinal(6)] 
		[RED("SetBackground")] 
		public gameuiStickerBackgroundCallback SetBackground
		{
			get => GetProperty(ref _setBackground);
			set => SetProperty(ref _setBackground, value);
		}

		[Ordinal(7)] 
		[RED("SetSetSelectedSticker")] 
		public gameuiStickerCallback SetSetSelectedSticker
		{
			get => GetProperty(ref _setSetSelectedSticker);
			set => SetProperty(ref _setSetSelectedSticker, value);
		}

		[Ordinal(8)] 
		[RED("stickerLibraryId")] 
		public CName StickerLibraryId
		{
			get => GetProperty(ref _stickerLibraryId);
			set => SetProperty(ref _stickerLibraryId, value);
		}

		[Ordinal(9)] 
		[RED("stickersRoot")] 
		public inkWidgetReference StickersRoot
		{
			get => GetProperty(ref _stickersRoot);
			set => SetProperty(ref _stickersRoot, value);
		}

		[Ordinal(10)] 
		[RED("frameRoot")] 
		public inkWidgetReference FrameRoot
		{
			get => GetProperty(ref _frameRoot);
			set => SetProperty(ref _frameRoot, value);
		}

		[Ordinal(11)] 
		[RED("backgroundViewRoot")] 
		public inkWidgetReference BackgroundViewRoot
		{
			get => GetProperty(ref _backgroundViewRoot);
			set => SetProperty(ref _backgroundViewRoot, value);
		}

		[Ordinal(12)] 
		[RED("stickers")] 
		public CArray<CWeakHandle<inkWidget>> Stickers
		{
			get => GetProperty(ref _stickers);
			set => SetProperty(ref _stickers, value);
		}

		[Ordinal(13)] 
		[RED("frame")] 
		public CWeakHandle<inkWidget> Frame
		{
			get => GetProperty(ref _frame);
			set => SetProperty(ref _frame, value);
		}

		[Ordinal(14)] 
		[RED("frameLogic")] 
		public CWeakHandle<PhotoModeFrame> FrameLogic
		{
			get => GetProperty(ref _frameLogic);
			set => SetProperty(ref _frameLogic, value);
		}

		[Ordinal(15)] 
		[RED("currentHovered")] 
		public CInt32 CurrentHovered
		{
			get => GetProperty(ref _currentHovered);
			set => SetProperty(ref _currentHovered, value);
		}

		[Ordinal(16)] 
		[RED("currentMouseDrag")] 
		public CInt32 CurrentMouseDrag
		{
			get => GetProperty(ref _currentMouseDrag);
			set => SetProperty(ref _currentMouseDrag, value);
		}

		[Ordinal(17)] 
		[RED("currentMouseRotate")] 
		public CInt32 CurrentMouseRotate
		{
			get => GetProperty(ref _currentMouseRotate);
			set => SetProperty(ref _currentMouseRotate, value);
		}

		[Ordinal(18)] 
		[RED("stickerDragStartRotation")] 
		public CFloat StickerDragStartRotation
		{
			get => GetProperty(ref _stickerDragStartRotation);
			set => SetProperty(ref _stickerDragStartRotation, value);
		}

		[Ordinal(19)] 
		[RED("stickerDragStartScale")] 
		public Vector2 StickerDragStartScale
		{
			get => GetProperty(ref _stickerDragStartScale);
			set => SetProperty(ref _stickerDragStartScale, value);
		}

		[Ordinal(20)] 
		[RED("stickerDragStartPos")] 
		public Vector2 StickerDragStartPos
		{
			get => GetProperty(ref _stickerDragStartPos);
			set => SetProperty(ref _stickerDragStartPos, value);
		}

		[Ordinal(21)] 
		[RED("mouseDragStartPos")] 
		public Vector2 MouseDragStartPos
		{
			get => GetProperty(ref _mouseDragStartPos);
			set => SetProperty(ref _mouseDragStartPos, value);
		}

		[Ordinal(22)] 
		[RED("mouseDragCurrentPos")] 
		public Vector2 MouseDragCurrentPos
		{
			get => GetProperty(ref _mouseDragCurrentPos);
			set => SetProperty(ref _mouseDragCurrentPos, value);
		}

		[Ordinal(23)] 
		[RED("currentSticker")] 
		public CInt32 CurrentSticker
		{
			get => GetProperty(ref _currentSticker);
			set => SetProperty(ref _currentSticker, value);
		}

		[Ordinal(24)] 
		[RED("stickerMove")] 
		public Vector2 StickerMove
		{
			get => GetProperty(ref _stickerMove);
			set => SetProperty(ref _stickerMove, value);
		}

		[Ordinal(25)] 
		[RED("stickerRotation")] 
		public CFloat StickerRotation
		{
			get => GetProperty(ref _stickerRotation);
			set => SetProperty(ref _stickerRotation, value);
		}

		[Ordinal(26)] 
		[RED("stickerScale")] 
		public CFloat StickerScale
		{
			get => GetProperty(ref _stickerScale);
			set => SetProperty(ref _stickerScale, value);
		}

		[Ordinal(27)] 
		[RED("stickersAreaSize")] 
		public Vector2 StickersAreaSize
		{
			get => GetProperty(ref _stickersAreaSize);
			set => SetProperty(ref _stickersAreaSize, value);
		}

		[Ordinal(28)] 
		[RED("cursorInputEnabled")] 
		public CBool CursorInputEnabled
		{
			get => GetProperty(ref _cursorInputEnabled);
			set => SetProperty(ref _cursorInputEnabled, value);
		}

		[Ordinal(29)] 
		[RED("editorEnabled")] 
		public CBool EditorEnabled
		{
			get => GetProperty(ref _editorEnabled);
			set => SetProperty(ref _editorEnabled, value);
		}

		[Ordinal(30)] 
		[RED("root")] 
		public CWeakHandle<inkCanvasWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(31)] 
		[RED("isInPhotoMode")] 
		public CBool IsInPhotoMode
		{
			get => GetProperty(ref _isInPhotoMode);
			set => SetProperty(ref _isInPhotoMode, value);
		}
	}
}
