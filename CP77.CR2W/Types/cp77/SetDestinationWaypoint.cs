using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetDestinationWaypoint : AIActionHelperTask
	{
		[Ordinal(0)]  [RED("actionTweakIDMapping")] public CHandle<AIArgumentMapping> ActionTweakIDMapping { get; set; }
		[Ordinal(1)]  [RED("actionStringName")] public CString ActionStringName { get; set; }
		[Ordinal(2)]  [RED("initialized")] public CBool Initialized { get; set; }
		[Ordinal(3)]  [RED("actionName")] public CName ActionName { get; set; }
		[Ordinal(4)]  [RED("actionID")] public TweakDBID ActionID { get; set; }
		[Ordinal(5)]  [RED("refTargetType")] public CEnum<EAITargetType> RefTargetType { get; set; }
		[Ordinal(6)]  [RED("findClosest")] public CBool FindClosest { get; set; }
		[Ordinal(7)]  [RED("waypointsName")] public CName WaypointsName { get; set; }
		[Ordinal(8)]  [RED("destinations")] public CArray<Vector4> Destinations { get; set; }
		[Ordinal(9)]  [RED("finalDestinations")] public CArray<Vector4> FinalDestinations { get; set; }

		public SetDestinationWaypoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
