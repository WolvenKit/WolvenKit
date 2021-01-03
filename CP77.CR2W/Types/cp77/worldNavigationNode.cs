using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldNavigationNode : worldNode
	{
		[Ordinal(0)]  [RED("navigationTileResource")] public raRef<worldNavigationTileResource> NavigationTileResource { get; set; }

		public worldNavigationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
