using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CollisionExitingEvents : ImmediateExitWithForceEvents
	{
		[Ordinal(0)]  [RED("stateMachineInitData")] public wCHandle<VehicleTransitionInitData> StateMachineInitData { get; set; }
		[Ordinal(1)]  [RED("isCameraTogglePressed")] public CBool IsCameraTogglePressed { get; set; }
		[Ordinal(2)]  [RED("cameraToggleHoldToResetTimeSeconds")] public CFloat CameraToggleHoldToResetTimeSeconds { get; set; }
		[Ordinal(3)]  [RED("exitForce")] public gamestateMachineResultVector ExitForce { get; set; }
		[Ordinal(4)]  [RED("bikeForce")] public gamestateMachineResultVector BikeForce { get; set; }
		[Ordinal(5)]  [RED("knockOverBike")] public CHandle<KnockOverBikeEvent> KnockOverBike { get; set; }
		[Ordinal(6)]  [RED("animFeatureStatusEffect")] public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect { get; set; }

		public CollisionExitingEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
