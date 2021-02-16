using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiStadiaControllersGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("stadiaControllerPage")] public inkWidgetReference StadiaControllerPage { get; set; }
		[Ordinal(4)] [RED("nintendoControllerPage")] public inkWidgetReference NintendoControllerPage { get; set; }
		[Ordinal(5)] [RED("durangoControllerPage")] public inkWidgetReference DurangoControllerPage { get; set; }
		[Ordinal(6)] [RED("orbisControllerPage")] public inkWidgetReference OrbisControllerPage { get; set; }

		public gameuiStadiaControllersGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
