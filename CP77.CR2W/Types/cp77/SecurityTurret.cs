using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityTurret : SensorDevice
	{
		[Ordinal(12)]  [RED("netClientCurrentlyAppliedState")] public CHandle<SecurityTurretReplicatedState> NetClientCurrentlyAppliedState { get; set; }
		[Ordinal(179)]  [RED("animFeature")] public CHandle<AnimFeature_SecurityTurretData> AnimFeature { get; set; }
		[Ordinal(180)]  [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(181)]  [RED("lookAtSlot")] public CHandle<entSlotComponent> LookAtSlot { get; set; }
		[Ordinal(182)]  [RED("laserMesh")] public CHandle<entMeshComponent> LaserMesh { get; set; }
		[Ordinal(183)]  [RED("targetingComp")] public CHandle<gameTargetingComponent> TargetingComp { get; set; }
		[Ordinal(184)]  [RED("triggerSideOne")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne { get; set; }
		[Ordinal(185)]  [RED("triggerSideTwo")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo { get; set; }
		[Ordinal(186)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }
		[Ordinal(187)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(188)]  [RED("laserGameEffect")] public CHandle<gameEffectInstance> LaserGameEffect { get; set; }
		[Ordinal(189)]  [RED("laserFXSlotName")] public CName LaserFXSlotName { get; set; }
		[Ordinal(190)]  [RED("burstDelayEvtID")] public gameDelayID BurstDelayEvtID { get; set; }
		[Ordinal(191)]  [RED("isBurstDelayOngoing")] public CBool IsBurstDelayOngoing { get; set; }
		[Ordinal(192)]  [RED("nextShootCycleDelayEvtID")] public gameDelayID NextShootCycleDelayEvtID { get; set; }
		[Ordinal(193)]  [RED("isShootingOngoing")] public CBool IsShootingOngoing { get; set; }
		[Ordinal(194)]  [RED("timeToNextShot")] public CFloat TimeToNextShot { get; set; }
		[Ordinal(195)]  [RED("optim_CheckTargetParametersShots")] public CInt32 Optim_CheckTargetParametersShots { get; set; }

		public SecurityTurret(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
