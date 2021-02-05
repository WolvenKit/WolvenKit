using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseMinimapMappinController : gameuiMappinBaseController
	{
		[Ordinal(0)]  [RED("iconOrientation")] public CEnum<gameuiEIconOrientation> IconOrientation { get; set; }
		[Ordinal(1)]  [RED("fixedOrientationWidget")] public inkWidgetReference FixedOrientationWidget { get; set; }
		[Ordinal(2)]  [RED("clampArrowWidget")] public inkWidgetReference ClampArrowWidget { get; set; }

		public gameuiBaseMinimapMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
