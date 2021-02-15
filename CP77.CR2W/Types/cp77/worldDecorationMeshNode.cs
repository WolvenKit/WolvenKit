using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDecorationMeshNode : worldMeshNode
	{
		[Ordinal(13)] [RED("startAsleep")] public CBool StartAsleep { get; set; }
		[Ordinal(14)] [RED("filterDataSource")] public CEnum<physicsFilterDataSource> FilterDataSource { get; set; }
		[Ordinal(15)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }

		public worldDecorationMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
