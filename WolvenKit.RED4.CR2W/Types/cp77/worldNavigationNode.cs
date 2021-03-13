using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationNode : worldNode
	{
		[Ordinal(4)] [RED("navigationTileResource")] public raRef<worldNavigationTileResource> NavigationTileResource { get; set; }

		public worldNavigationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
