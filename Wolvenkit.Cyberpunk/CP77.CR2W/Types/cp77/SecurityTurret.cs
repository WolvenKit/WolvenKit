using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityTurret : SensorDevice
	{
		[Ordinal(0)]  [RED("animFeature")] public CHandle<AnimFeature_SecurityTurretData> AnimFeature { get; set; }
		[Ordinal(1)]  [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(2)]  [RED("burstDelayEvtID")] public gameDelayID BurstDelayEvtID { get; set; }
		[Ordinal(3)]  [RED("isBurstDelayOngoing")] public CBool IsBurstDelayOngoing { get; set; }
		[Ordinal(4)]  [RED("isShootingOngoing")] public CBool IsShootingOngoing { get; set; }
		[Ordinal(5)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(6)]  [RED("laserFXSlotName")] public CName LaserFXSlotName { get; set; }
		[Ordinal(7)]  [RED("laserGameEffect")] public CHandle<gameEffectInstance> LaserGameEffect { get; set; }
		[Ordinal(8)]  [RED("laserMesh")] public CHandle<entMeshComponent> LaserMesh { get; set; }
		[Ordinal(9)]  [RED("lookAtSlot")] public CHandle<entSlotComponent> LookAtSlot { get; set; }
		[Ordinal(10)]  [RED("netClientCurrentlyAppliedState")] public CHandle<SecurityTurretReplicatedState> NetClientCurrentlyAppliedState { get; set; }
		[Ordinal(11)]  [RED("nextShootCycleDelayEvtID")] public gameDelayID NextShootCycleDelayEvtID { get; set; }
		[Ordinal(12)]  [RED("optim_CheckTargetParametersShots")] public CInt32 Optim_CheckTargetParametersShots { get; set; }
		[Ordinal(13)]  [RED("targetingComp")] public CHandle<gameTargetingComponent> TargetingComp { get; set; }
		[Ordinal(14)]  [RED("timeToNextShot")] public CFloat TimeToNextShot { get; set; }
		[Ordinal(15)]  [RED("triggerSideOne")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne { get; set; }
		[Ordinal(16)]  [RED("triggerSideTwo")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo { get; set; }
		[Ordinal(17)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }

		public SecurityTurret(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
