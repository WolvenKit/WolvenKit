using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCreditsPositionController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("namesText")] public inkTextWidgetReference NamesText { get; set; }
		[Ordinal(1)]  [RED("titleText")] public inkTextWidgetReference TitleText { get; set; }

		public gameuiCreditsPositionController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
