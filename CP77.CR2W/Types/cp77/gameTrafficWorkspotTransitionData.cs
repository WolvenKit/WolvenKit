using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTrafficWorkspotTransitionData : ISerializable
	{
		[Ordinal(0)]  [RED("workspotData")] public CHandle<gameSetupWorkspotActionEvent> WorkspotData { get; set; }
		[Ordinal(1)]  [RED("returnPosition")] public CHandle<worldTrafficGlobalPathPosition> ReturnPosition { get; set; }
		[Ordinal(2)]  [RED("workspotExitTangent")] public Vector3 WorkspotExitTangent { get; set; }
		[Ordinal(3)]  [RED("trafficLaneReturnTangent")] public Vector3 TrafficLaneReturnTangent { get; set; }

		public gameTrafficWorkspotTransitionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
