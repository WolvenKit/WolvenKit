using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeStickersController : gameuiWidgetGameController
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
		private CArray<wCHandle<inkWidget>> _stickers;
		private wCHandle<inkWidget> _frame;
		private CHandle<PhotoModeFrame> _frameLogic;
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
		private wCHandle<inkCanvasWidget> _root;
		private CBool _isInPhotoMode;

		[Ordinal(2)] 
		[RED("backgroundPrefabRef")] 
		public NodeRef BackgroundPrefabRef
		{
			get
			{
				if (_backgroundPrefabRef == null)
				{
					_backgroundPrefabRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "backgroundPrefabRef", cr2w, this);
				}
				return _backgroundPrefabRef;
			}
			set
			{
				if (_backgroundPrefabRef == value)
				{
					return;
				}
				_backgroundPrefabRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ResetStickers")] 
		public inkEmptyCallback ResetStickers
		{
			get
			{
				if (_resetStickers == null)
				{
					_resetStickers = (inkEmptyCallback) CR2WTypeManager.Create("inkEmptyCallback", "ResetStickers", cr2w, this);
				}
				return _resetStickers;
			}
			set
			{
				if (_resetStickers == value)
				{
					return;
				}
				_resetStickers = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("SetStickerImage")] 
		public gameuiStickerImageCallback SetStickerImage
		{
			get
			{
				if (_setStickerImage == null)
				{
					_setStickerImage = (gameuiStickerImageCallback) CR2WTypeManager.Create("gameuiStickerImageCallback", "SetStickerImage", cr2w, this);
				}
				return _setStickerImage;
			}
			set
			{
				if (_setStickerImage == value)
				{
					return;
				}
				_setStickerImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("SetFrameImage")] 
		public gameuiStickerFrameCallback SetFrameImage
		{
			get
			{
				if (_setFrameImage == null)
				{
					_setFrameImage = (gameuiStickerFrameCallback) CR2WTypeManager.Create("gameuiStickerFrameCallback", "SetFrameImage", cr2w, this);
				}
				return _setFrameImage;
			}
			set
			{
				if (_setFrameImage == value)
				{
					return;
				}
				_setFrameImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("SetBackground")] 
		public gameuiStickerBackgroundCallback SetBackground
		{
			get
			{
				if (_setBackground == null)
				{
					_setBackground = (gameuiStickerBackgroundCallback) CR2WTypeManager.Create("gameuiStickerBackgroundCallback", "SetBackground", cr2w, this);
				}
				return _setBackground;
			}
			set
			{
				if (_setBackground == value)
				{
					return;
				}
				_setBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("SetSetSelectedSticker")] 
		public gameuiStickerCallback SetSetSelectedSticker
		{
			get
			{
				if (_setSetSelectedSticker == null)
				{
					_setSetSelectedSticker = (gameuiStickerCallback) CR2WTypeManager.Create("gameuiStickerCallback", "SetSetSelectedSticker", cr2w, this);
				}
				return _setSetSelectedSticker;
			}
			set
			{
				if (_setSetSelectedSticker == value)
				{
					return;
				}
				_setSetSelectedSticker = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("stickerLibraryId")] 
		public CName StickerLibraryId
		{
			get
			{
				if (_stickerLibraryId == null)
				{
					_stickerLibraryId = (CName) CR2WTypeManager.Create("CName", "stickerLibraryId", cr2w, this);
				}
				return _stickerLibraryId;
			}
			set
			{
				if (_stickerLibraryId == value)
				{
					return;
				}
				_stickerLibraryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("stickersRoot")] 
		public inkWidgetReference StickersRoot
		{
			get
			{
				if (_stickersRoot == null)
				{
					_stickersRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "stickersRoot", cr2w, this);
				}
				return _stickersRoot;
			}
			set
			{
				if (_stickersRoot == value)
				{
					return;
				}
				_stickersRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("frameRoot")] 
		public inkWidgetReference FrameRoot
		{
			get
			{
				if (_frameRoot == null)
				{
					_frameRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "frameRoot", cr2w, this);
				}
				return _frameRoot;
			}
			set
			{
				if (_frameRoot == value)
				{
					return;
				}
				_frameRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("backgroundViewRoot")] 
		public inkWidgetReference BackgroundViewRoot
		{
			get
			{
				if (_backgroundViewRoot == null)
				{
					_backgroundViewRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "backgroundViewRoot", cr2w, this);
				}
				return _backgroundViewRoot;
			}
			set
			{
				if (_backgroundViewRoot == value)
				{
					return;
				}
				_backgroundViewRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("stickers")] 
		public CArray<wCHandle<inkWidget>> Stickers
		{
			get
			{
				if (_stickers == null)
				{
					_stickers = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "stickers", cr2w, this);
				}
				return _stickers;
			}
			set
			{
				if (_stickers == value)
				{
					return;
				}
				_stickers = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("frame")] 
		public wCHandle<inkWidget> Frame
		{
			get
			{
				if (_frame == null)
				{
					_frame = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "frame", cr2w, this);
				}
				return _frame;
			}
			set
			{
				if (_frame == value)
				{
					return;
				}
				_frame = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("frameLogic")] 
		public CHandle<PhotoModeFrame> FrameLogic
		{
			get
			{
				if (_frameLogic == null)
				{
					_frameLogic = (CHandle<PhotoModeFrame>) CR2WTypeManager.Create("handle:PhotoModeFrame", "frameLogic", cr2w, this);
				}
				return _frameLogic;
			}
			set
			{
				if (_frameLogic == value)
				{
					return;
				}
				_frameLogic = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("currentHovered")] 
		public CInt32 CurrentHovered
		{
			get
			{
				if (_currentHovered == null)
				{
					_currentHovered = (CInt32) CR2WTypeManager.Create("Int32", "currentHovered", cr2w, this);
				}
				return _currentHovered;
			}
			set
			{
				if (_currentHovered == value)
				{
					return;
				}
				_currentHovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("currentMouseDrag")] 
		public CInt32 CurrentMouseDrag
		{
			get
			{
				if (_currentMouseDrag == null)
				{
					_currentMouseDrag = (CInt32) CR2WTypeManager.Create("Int32", "currentMouseDrag", cr2w, this);
				}
				return _currentMouseDrag;
			}
			set
			{
				if (_currentMouseDrag == value)
				{
					return;
				}
				_currentMouseDrag = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("currentMouseRotate")] 
		public CInt32 CurrentMouseRotate
		{
			get
			{
				if (_currentMouseRotate == null)
				{
					_currentMouseRotate = (CInt32) CR2WTypeManager.Create("Int32", "currentMouseRotate", cr2w, this);
				}
				return _currentMouseRotate;
			}
			set
			{
				if (_currentMouseRotate == value)
				{
					return;
				}
				_currentMouseRotate = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("stickerDragStartRotation")] 
		public CFloat StickerDragStartRotation
		{
			get
			{
				if (_stickerDragStartRotation == null)
				{
					_stickerDragStartRotation = (CFloat) CR2WTypeManager.Create("Float", "stickerDragStartRotation", cr2w, this);
				}
				return _stickerDragStartRotation;
			}
			set
			{
				if (_stickerDragStartRotation == value)
				{
					return;
				}
				_stickerDragStartRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("stickerDragStartScale")] 
		public Vector2 StickerDragStartScale
		{
			get
			{
				if (_stickerDragStartScale == null)
				{
					_stickerDragStartScale = (Vector2) CR2WTypeManager.Create("Vector2", "stickerDragStartScale", cr2w, this);
				}
				return _stickerDragStartScale;
			}
			set
			{
				if (_stickerDragStartScale == value)
				{
					return;
				}
				_stickerDragStartScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("stickerDragStartPos")] 
		public Vector2 StickerDragStartPos
		{
			get
			{
				if (_stickerDragStartPos == null)
				{
					_stickerDragStartPos = (Vector2) CR2WTypeManager.Create("Vector2", "stickerDragStartPos", cr2w, this);
				}
				return _stickerDragStartPos;
			}
			set
			{
				if (_stickerDragStartPos == value)
				{
					return;
				}
				_stickerDragStartPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("mouseDragStartPos")] 
		public Vector2 MouseDragStartPos
		{
			get
			{
				if (_mouseDragStartPos == null)
				{
					_mouseDragStartPos = (Vector2) CR2WTypeManager.Create("Vector2", "mouseDragStartPos", cr2w, this);
				}
				return _mouseDragStartPos;
			}
			set
			{
				if (_mouseDragStartPos == value)
				{
					return;
				}
				_mouseDragStartPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("mouseDragCurrentPos")] 
		public Vector2 MouseDragCurrentPos
		{
			get
			{
				if (_mouseDragCurrentPos == null)
				{
					_mouseDragCurrentPos = (Vector2) CR2WTypeManager.Create("Vector2", "mouseDragCurrentPos", cr2w, this);
				}
				return _mouseDragCurrentPos;
			}
			set
			{
				if (_mouseDragCurrentPos == value)
				{
					return;
				}
				_mouseDragCurrentPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("currentSticker")] 
		public CInt32 CurrentSticker
		{
			get
			{
				if (_currentSticker == null)
				{
					_currentSticker = (CInt32) CR2WTypeManager.Create("Int32", "currentSticker", cr2w, this);
				}
				return _currentSticker;
			}
			set
			{
				if (_currentSticker == value)
				{
					return;
				}
				_currentSticker = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("stickerMove")] 
		public Vector2 StickerMove
		{
			get
			{
				if (_stickerMove == null)
				{
					_stickerMove = (Vector2) CR2WTypeManager.Create("Vector2", "stickerMove", cr2w, this);
				}
				return _stickerMove;
			}
			set
			{
				if (_stickerMove == value)
				{
					return;
				}
				_stickerMove = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("stickerRotation")] 
		public CFloat StickerRotation
		{
			get
			{
				if (_stickerRotation == null)
				{
					_stickerRotation = (CFloat) CR2WTypeManager.Create("Float", "stickerRotation", cr2w, this);
				}
				return _stickerRotation;
			}
			set
			{
				if (_stickerRotation == value)
				{
					return;
				}
				_stickerRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("stickerScale")] 
		public CFloat StickerScale
		{
			get
			{
				if (_stickerScale == null)
				{
					_stickerScale = (CFloat) CR2WTypeManager.Create("Float", "stickerScale", cr2w, this);
				}
				return _stickerScale;
			}
			set
			{
				if (_stickerScale == value)
				{
					return;
				}
				_stickerScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("stickersAreaSize")] 
		public Vector2 StickersAreaSize
		{
			get
			{
				if (_stickersAreaSize == null)
				{
					_stickersAreaSize = (Vector2) CR2WTypeManager.Create("Vector2", "stickersAreaSize", cr2w, this);
				}
				return _stickersAreaSize;
			}
			set
			{
				if (_stickersAreaSize == value)
				{
					return;
				}
				_stickersAreaSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("cursorInputEnabled")] 
		public CBool CursorInputEnabled
		{
			get
			{
				if (_cursorInputEnabled == null)
				{
					_cursorInputEnabled = (CBool) CR2WTypeManager.Create("Bool", "cursorInputEnabled", cr2w, this);
				}
				return _cursorInputEnabled;
			}
			set
			{
				if (_cursorInputEnabled == value)
				{
					return;
				}
				_cursorInputEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("editorEnabled")] 
		public CBool EditorEnabled
		{
			get
			{
				if (_editorEnabled == null)
				{
					_editorEnabled = (CBool) CR2WTypeManager.Create("Bool", "editorEnabled", cr2w, this);
				}
				return _editorEnabled;
			}
			set
			{
				if (_editorEnabled == value)
				{
					return;
				}
				_editorEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("root")] 
		public wCHandle<inkCanvasWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("isInPhotoMode")] 
		public CBool IsInPhotoMode
		{
			get
			{
				if (_isInPhotoMode == null)
				{
					_isInPhotoMode = (CBool) CR2WTypeManager.Create("Bool", "isInPhotoMode", cr2w, this);
				}
				return _isInPhotoMode;
			}
			set
			{
				if (_isInPhotoMode == value)
				{
					return;
				}
				_isInPhotoMode = value;
				PropertySet(this);
			}
		}

		public gameuiPhotoModeStickersController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
