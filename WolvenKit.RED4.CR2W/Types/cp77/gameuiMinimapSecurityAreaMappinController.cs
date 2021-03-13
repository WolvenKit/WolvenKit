using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapSecurityAreaMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] [RED("playerInArea")] public CBool PlayerInArea { get; set; }
		[Ordinal(15)] [RED("area")] public CHandle<gamemappinsIArea> Area { get; set; }
		[Ordinal(16)] [RED("areaShapeWidget")] public inkShapeWidgetReference AreaShapeWidget { get; set; }

		public gameuiMinimapSecurityAreaMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
