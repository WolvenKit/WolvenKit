using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class artist_test_area_r : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(10)] [RED("linesWidget")] public wCHandle<inkCanvasWidget> LinesWidget { get; set; }

		public artist_test_area_r(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
