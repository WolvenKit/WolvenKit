using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMuppetState : CVariable
	{
		[Ordinal(0)]  [RED("abilities")] public gameMuppetAbilities Abilities { get; set; }
		[Ordinal(1)]  [RED("controllersSnapshot")] public gameMuppetControllersSnapshot ControllersSnapshot { get; set; }
		[Ordinal(2)]  [RED("frameId")] public CUInt32 FrameId { get; set; }
		[Ordinal(3)]  [RED("healthState")] public gameMuppetHealthState HealthState { get; set; }
		[Ordinal(4)]  [RED("highLevelState")] public gameMuppetHighLevelState HighLevelState { get; set; }
		[Ordinal(5)]  [RED("inventoryState")] public gameMuppetInventoryState InventoryState { get; set; }
		[Ordinal(6)]  [RED("lookState")] public gameMuppetLookState LookState { get; set; }
		[Ordinal(7)]  [RED("moveState")] public gameMuppetMoveState MoveState { get; set; }
		[Ordinal(8)]  [RED("physicalMoveState")] public gameMuppetPhysicalState PhysicalMoveState { get; set; }
		[Ordinal(9)]  [RED("scanningState")] public gameMuppetScanningState ScanningState { get; set; }
		[Ordinal(10)]  [RED("snapFrameId")] public CUInt32 SnapFrameId { get; set; }
		[Ordinal(11)]  [RED("stateMachinesSnapshot")] public gameMuppetStateMachinesSnapshot StateMachinesSnapshot { get; set; }
		[Ordinal(12)]  [RED("upperBodyState")] public gameMuppetUpperBodyState UpperBodyState { get; set; }

		public gameMuppetState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
