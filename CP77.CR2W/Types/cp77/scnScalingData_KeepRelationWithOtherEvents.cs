using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnScalingData_KeepRelationWithOtherEvents : scnIScalingData
	{
		[Ordinal(0)] [RED("groupRfrncNdspaceStarttime")] public scnSceneTime GroupRfrncNdspaceStarttime { get; set; }
		[Ordinal(1)] [RED("groupRfrncNdspaceEndtime")] public scnSceneTime GroupRfrncNdspaceEndtime { get; set; }

		public scnScalingData_KeepRelationWithOtherEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
