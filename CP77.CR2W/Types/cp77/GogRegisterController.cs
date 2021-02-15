using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GogRegisterController : gameuiBaseGOGRegisterController
	{
		[Ordinal(1)] [RED("linkWidget")] public inkWidgetReference LinkWidget { get; set; }
		[Ordinal(2)] [RED("qrImageWidget")] public inkWidgetReference QrImageWidget { get; set; }

		public GogRegisterController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
