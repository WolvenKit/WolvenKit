using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseMinimapMappinController : gameuiMappinBaseController
	{
		[Ordinal(3)]  [RED("iconOrientation")] public CEnum<gameuiEIconOrientation> IconOrientation { get; set; }
		[Ordinal(4)]  [RED("fixedOrientationWidget")] public inkWidgetReference FixedOrientationWidget { get; set; }
		[Ordinal(5)]  [RED("clampArrowWidget")] public inkWidgetReference ClampArrowWidget { get; set; }
		[Ordinal(6)]  [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(7)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(8)]  [RED("aboveWidget")] public wCHandle<inkWidget> AboveWidget { get; set; }
		[Ordinal(9)]  [RED("belowWidget")] public wCHandle<inkWidget> BelowWidget { get; set; }

		public gameuiBaseMinimapMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
