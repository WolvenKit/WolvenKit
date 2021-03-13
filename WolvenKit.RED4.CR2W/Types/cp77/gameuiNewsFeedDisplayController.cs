using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNewsFeedDisplayController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("newsTitleWidget")] public inkTextWidgetReference NewsTitleWidget { get; set; }
		[Ordinal(2)] [RED("randomNewsLibraryWidget")] public CName RandomNewsLibraryWidget { get; set; }
		[Ordinal(3)] [RED("randomNewsContainer")] public inkCompoundWidgetReference RandomNewsContainer { get; set; }

		public gameuiNewsFeedDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
