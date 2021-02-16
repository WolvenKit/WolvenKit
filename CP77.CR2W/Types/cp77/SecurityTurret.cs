using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityTurret : SensorDevice
	{
		[Ordinal(187)] [RED("animFeature")] public CHandle<AnimFeature_SecurityTurretData> AnimFeature { get; set; }
		[Ordinal(188)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(189)] [RED("lookAtSlot")] public CHandle<entSlotComponent> LookAtSlot { get; set; }
		[Ordinal(190)] [RED("laserMesh")] public CHandle<entMeshComponent> LaserMesh { get; set; }
		[Ordinal(191)] [RED("targetingComp")] public CHandle<gameTargetingComponent> TargetingComp { get; set; }
		[Ordinal(192)] [RED("triggerSideOne")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne { get; set; }
		[Ordinal(193)] [RED("triggerSideTwo")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo { get; set; }
		[Ordinal(194)] [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }
		[Ordinal(195)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(196)] [RED("laserGameEffect")] public CHandle<gameEffectInstance> LaserGameEffect { get; set; }
		[Ordinal(197)] [RED("laserFXSlotName")] public CName LaserFXSlotName { get; set; }
		[Ordinal(198)] [RED("burstDelayEvtID")] public gameDelayID BurstDelayEvtID { get; set; }
		[Ordinal(199)] [RED("isBurstDelayOngoing")] public CBool IsBurstDelayOngoing { get; set; }
		[Ordinal(200)] [RED("nextShootCycleDelayEvtID")] public gameDelayID NextShootCycleDelayEvtID { get; set; }
		[Ordinal(201)] [RED("isShootingOngoing")] public CBool IsShootingOngoing { get; set; }
		[Ordinal(202)] [RED("timeToNextShot")] public CFloat TimeToNextShot { get; set; }
		[Ordinal(203)] [RED("optim_CheckTargetParametersShots")] public CInt32 Optim_CheckTargetParametersShots { get; set; }
		[Ordinal(204)] [RED("netClientCurrentlyAppliedState")] public CHandle<SecurityTurretReplicatedState> NetClientCurrentlyAppliedState { get; set; }

		public SecurityTurret(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
