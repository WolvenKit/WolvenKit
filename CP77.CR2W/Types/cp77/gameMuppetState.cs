using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetState : CVariable
	{
		[Ordinal(0)]  [RED("frameId")] public CUInt32 FrameId { get; set; }
		[Ordinal(1)]  [RED("highLevelState")] public gameMuppetHighLevelState HighLevelState { get; set; }
		[Ordinal(2)]  [RED("healthState")] public gameMuppetHealthState HealthState { get; set; }
		[Ordinal(3)]  [RED("physicalMoveState")] public gameMuppetPhysicalState PhysicalMoveState { get; set; }
		[Ordinal(4)]  [RED("lookState")] public gameMuppetLookState LookState { get; set; }
		[Ordinal(5)]  [RED("moveState")] public gameMuppetMoveState MoveState { get; set; }
		[Ordinal(6)]  [RED("upperBodyState")] public gameMuppetUpperBodyState UpperBodyState { get; set; }
		[Ordinal(7)]  [RED("scanningState")] public gameMuppetScanningState ScanningState { get; set; }
		[Ordinal(8)]  [RED("inventoryState")] public gameMuppetInventoryState InventoryState { get; set; }
		[Ordinal(9)]  [RED("abilities")] public gameMuppetAbilities Abilities { get; set; }
		[Ordinal(10)]  [RED("stateMachinesSnapshot")] public gameMuppetStateMachinesSnapshot StateMachinesSnapshot { get; set; }
		[Ordinal(11)]  [RED("controllersSnapshot")] public gameMuppetControllersSnapshot ControllersSnapshot { get; set; }
		[Ordinal(12)]  [RED("snapFrameId")] public CUInt32 SnapFrameId { get; set; }

		public gameMuppetState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
