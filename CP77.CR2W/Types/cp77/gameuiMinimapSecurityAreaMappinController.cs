using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapSecurityAreaMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(0)]  [RED("area")] public CHandle<gamemappinsIArea> Area { get; set; }
		[Ordinal(1)]  [RED("areaShapeWidget")] public inkShapeWidgetReference AreaShapeWidget { get; set; }
		[Ordinal(2)]  [RED("playerInArea")] public CBool PlayerInArea { get; set; }

		public gameuiMinimapSecurityAreaMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
