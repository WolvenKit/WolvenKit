using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ImageActionButtonLogicController : DeviceActionWidgetControllerBase
	{
		[Ordinal(0)]  [RED("price")] public CInt32 Price { get; set; }
		[Ordinal(1)]  [RED("tallImageWidget")] public inkImageWidgetReference TallImageWidget { get; set; }

		public ImageActionButtonLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
