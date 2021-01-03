using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeStickersController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("ResetStickers")] public inkEmptyCallback ResetStickers { get; set; }
		[Ordinal(1)]  [RED("SetBackground")] public gameuiStickerBackgroundCallback SetBackground { get; set; }
		[Ordinal(2)]  [RED("SetFrameImage")] public gameuiStickerFrameCallback SetFrameImage { get; set; }
		[Ordinal(3)]  [RED("SetSetSelectedSticker")] public gameuiStickerCallback SetSetSelectedSticker { get; set; }
		[Ordinal(4)]  [RED("SetStickerImage")] public gameuiStickerImageCallback SetStickerImage { get; set; }
		[Ordinal(5)]  [RED("backgroundPrefabRef")] public NodeRef BackgroundPrefabRef { get; set; }
		[Ordinal(6)]  [RED("backgroundViewRoot")] public inkWidgetReference BackgroundViewRoot { get; set; }
		[Ordinal(7)]  [RED("currentHovered")] public CInt32 CurrentHovered { get; set; }
		[Ordinal(8)]  [RED("currentMouseDrag")] public CInt32 CurrentMouseDrag { get; set; }
		[Ordinal(9)]  [RED("currentMouseRotate")] public CInt32 CurrentMouseRotate { get; set; }
		[Ordinal(10)]  [RED("currentSticker")] public CInt32 CurrentSticker { get; set; }
		[Ordinal(11)]  [RED("cursorInputEnabled")] public CBool CursorInputEnabled { get; set; }
		[Ordinal(12)]  [RED("editorEnabled")] public CBool EditorEnabled { get; set; }
		[Ordinal(13)]  [RED("frame")] public wCHandle<inkWidget> Frame { get; set; }
		[Ordinal(14)]  [RED("frameLogic")] public CHandle<PhotoModeFrame> FrameLogic { get; set; }
		[Ordinal(15)]  [RED("frameRoot")] public inkWidgetReference FrameRoot { get; set; }
		[Ordinal(16)]  [RED("isInPhotoMode")] public CBool IsInPhotoMode { get; set; }
		[Ordinal(17)]  [RED("mouseDragCurrentPos")] public Vector2 MouseDragCurrentPos { get; set; }
		[Ordinal(18)]  [RED("mouseDragStartPos")] public Vector2 MouseDragStartPos { get; set; }
		[Ordinal(19)]  [RED("root")] public wCHandle<inkCanvasWidget> Root { get; set; }
		[Ordinal(20)]  [RED("stickerDragStartPos")] public Vector2 StickerDragStartPos { get; set; }
		[Ordinal(21)]  [RED("stickerDragStartRotation")] public CFloat StickerDragStartRotation { get; set; }
		[Ordinal(22)]  [RED("stickerDragStartScale")] public Vector2 StickerDragStartScale { get; set; }
		[Ordinal(23)]  [RED("stickerLibraryId")] public CName StickerLibraryId { get; set; }
		[Ordinal(24)]  [RED("stickerMove")] public Vector2 StickerMove { get; set; }
		[Ordinal(25)]  [RED("stickerRotation")] public CFloat StickerRotation { get; set; }
		[Ordinal(26)]  [RED("stickerScale")] public CFloat StickerScale { get; set; }
		[Ordinal(27)]  [RED("stickers")] public CArray<wCHandle<inkWidget>> Stickers { get; set; }
		[Ordinal(28)]  [RED("stickersAreaSize")] public Vector2 StickersAreaSize { get; set; }
		[Ordinal(29)]  [RED("stickersRoot")] public inkWidgetReference StickersRoot { get; set; }

		public gameuiPhotoModeStickersController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
