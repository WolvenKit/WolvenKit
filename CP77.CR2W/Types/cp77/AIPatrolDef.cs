using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIPatrolDef : AIBlackboardDef
	{
		[Ordinal(0)]  [RED("closestPathPoint")] public gamebbScriptID_Vector4 ClosestPathPoint { get; set; }
		[Ordinal(1)]  [RED("forceAlerted")] public gamebbScriptID_Bool ForceAlerted { get; set; }
		[Ordinal(2)]  [RED("patrolAction")] public gamebbScriptID_Variant PatrolAction { get; set; }
		[Ordinal(3)]  [RED("patrolInProgress")] public gamebbScriptID_Bool PatrolInProgress { get; set; }
		[Ordinal(4)]  [RED("patrolPathOverride")] public gamebbScriptID_Variant PatrolPathOverride { get; set; }
		[Ordinal(5)]  [RED("patrolWithWeapon")] public gamebbScriptID_Bool PatrolWithWeapon { get; set; }
		[Ordinal(6)]  [RED("selectedPath")] public gamebbScriptID_Variant SelectedPath { get; set; }
		[Ordinal(7)]  [RED("sprint")] public gamebbScriptID_Bool Sprint { get; set; }
		[Ordinal(8)]  [RED("workspotData")] public gamebbScriptID_Variant WorkspotData { get; set; }
		[Ordinal(9)]  [RED("workspotEntryPosition")] public gamebbScriptID_Vector4 WorkspotEntryPosition { get; set; }
		[Ordinal(10)]  [RED("workspotExitPosition")] public gamebbScriptID_Vector4 WorkspotExitPosition { get; set; }

		public AIPatrolDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
