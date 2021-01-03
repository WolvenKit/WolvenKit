using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GogRegisterController : gameuiBaseGOGRegisterController
	{
		[Ordinal(0)]  [RED("linkWidget")] public inkWidgetReference LinkWidget { get; set; }
		[Ordinal(1)]  [RED("qrImageWidget")] public inkWidgetReference QrImageWidget { get; set; }

		public GogRegisterController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
