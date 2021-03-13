using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeSticker : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(2)] [RED("stickersController")] public CHandle<gameuiPhotoModeStickersController> StickersController { get; set; }

		public PhotoModeSticker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
