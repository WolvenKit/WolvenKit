using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldCollisionAreaNode : worldAreaShapeNode
	{
		[Ordinal(0)]  [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(1)]  [RED("material")] public CName Material { get; set; }
		[Ordinal(2)]  [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }

		public worldCollisionAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
