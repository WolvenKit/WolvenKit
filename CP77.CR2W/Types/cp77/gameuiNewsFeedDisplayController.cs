using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
