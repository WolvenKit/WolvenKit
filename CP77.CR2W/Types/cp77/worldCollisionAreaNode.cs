using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCollisionAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] [RED("material")] public CName Material { get; set; }
		[Ordinal(5)] [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }
		[Ordinal(6)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }

		public worldCollisionAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
