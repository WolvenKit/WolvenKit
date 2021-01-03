using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseMinimapMappinController : gameuiMappinBaseController
	{
		[Ordinal(0)]  [RED("aboveWidget")] public wCHandle<inkWidget> AboveWidget { get; set; }
		[Ordinal(1)]  [RED("belowWidget")] public wCHandle<inkWidget> BelowWidget { get; set; }
		[Ordinal(2)]  [RED("clampArrowWidget")] public inkWidgetReference ClampArrowWidget { get; set; }
		[Ordinal(3)]  [RED("fixedOrientationWidget")] public inkWidgetReference FixedOrientationWidget { get; set; }
		[Ordinal(4)]  [RED("iconOrientation")] public CEnum<gameuiEIconOrientation> IconOrientation { get; set; }
		[Ordinal(5)]  [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(6)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }

		public gameuiBaseMinimapMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
