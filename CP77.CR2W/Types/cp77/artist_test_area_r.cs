using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class artist_test_area_r : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("linesWidget")] public wCHandle<inkCanvasWidget> LinesWidget { get; set; }
		[Ordinal(1)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }

		public artist_test_area_r(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
