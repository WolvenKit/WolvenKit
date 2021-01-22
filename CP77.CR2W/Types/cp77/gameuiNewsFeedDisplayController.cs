using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiNewsFeedDisplayController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("newsTitleWidget")] public inkTextWidgetReference NewsTitleWidget { get; set; }
		[Ordinal(1)]  [RED("randomNewsContainer")] public inkCompoundWidgetReference RandomNewsContainer { get; set; }
		[Ordinal(2)]  [RED("randomNewsLibraryWidget")] public CName RandomNewsLibraryWidget { get; set; }

		public gameuiNewsFeedDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
