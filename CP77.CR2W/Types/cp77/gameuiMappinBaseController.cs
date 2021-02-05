using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMappinBaseController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("iconWidget")] public inkImageWidgetReference IconWidget { get; set; }
		[Ordinal(1)]  [RED("playerTrackedWidget")] public inkWidgetReference PlayerTrackedWidget { get; set; }
		[Ordinal(2)]  [RED("scaleWidget")] public inkWidgetReference ScaleWidget { get; set; }

		public gameuiMappinBaseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
