using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapSecurityAreaMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(0)]  [RED("playerInArea")] public CBool PlayerInArea { get; set; }
		[Ordinal(1)]  [RED("area")] public CHandle<gamemappinsIArea> Area { get; set; }
		[Ordinal(2)]  [RED("areaShapeWidget")] public inkShapeWidgetReference AreaShapeWidget { get; set; }

		public gameuiMinimapSecurityAreaMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
