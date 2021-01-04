using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhotoModeFrame : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("currentImagePart")] public CName CurrentImagePart { get; set; }
		[Ordinal(1)]  [RED("images")] public CArray<inkImageWidgetReference> Images { get; set; }
		[Ordinal(2)]  [RED("keepImageAspectRatio")] public CBool KeepImageAspectRatio { get; set; }
		[Ordinal(3)]  [RED("opacity")] public CFloat Opacity { get; set; }
		[Ordinal(4)]  [RED("stickersController")] public CHandle<gameuiPhotoModeStickersController> StickersController { get; set; }

		public PhotoModeFrame(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
