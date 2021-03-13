using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldNavigationNode : worldNode
	{
		[Ordinal(4)] [RED("navigationTileResource")] public raRef<worldNavigationTileResource> NavigationTileResource { get; set; }

		public worldNavigationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
