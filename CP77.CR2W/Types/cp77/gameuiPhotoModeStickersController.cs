using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeStickersController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("backgroundPrefabRef")] public NodeRef BackgroundPrefabRef { get; set; }
		[Ordinal(1)]  [RED("ResetStickers")] public inkEmptyCallback ResetStickers { get; set; }
		[Ordinal(2)]  [RED("SetStickerImage")] public gameuiStickerImageCallback SetStickerImage { get; set; }
		[Ordinal(3)]  [RED("SetFrameImage")] public gameuiStickerFrameCallback SetFrameImage { get; set; }
		[Ordinal(4)]  [RED("SetBackground")] public gameuiStickerBackgroundCallback SetBackground { get; set; }
		[Ordinal(5)]  [RED("SetSetSelectedSticker")] public gameuiStickerCallback SetSetSelectedSticker { get; set; }

		public gameuiPhotoModeStickersController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
