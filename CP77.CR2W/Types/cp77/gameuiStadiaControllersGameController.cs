using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiStadiaControllersGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("durangoControllerPage")] public inkWidgetReference DurangoControllerPage { get; set; }
		[Ordinal(1)]  [RED("nintendoControllerPage")] public inkWidgetReference NintendoControllerPage { get; set; }
		[Ordinal(2)]  [RED("orbisControllerPage")] public inkWidgetReference OrbisControllerPage { get; set; }
		[Ordinal(3)]  [RED("stadiaControllerPage")] public inkWidgetReference StadiaControllerPage { get; set; }

		public gameuiStadiaControllersGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
