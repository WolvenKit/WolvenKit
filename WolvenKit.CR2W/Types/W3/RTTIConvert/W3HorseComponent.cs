using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3HorseComponent : CVehicleComponent
	{
		[RED("riderSharedParams")] 		public CHandle<CHorseRiderSharedParams> RiderSharedParams { get; set;}

		[RED("lastRider")] 		public CHandle<CActor> LastRider { get; set;}

		[RED("originalAttitudeGroup")] 		public CName OriginalAttitudeGroup { get; set;}

		[RED("canDismount")] 		public CBool CanDismount { get; set;}

		[RED("inCanter")] 		public CBool InCanter { get; set;}

		[RED("inGallop")] 		public CBool InGallop { get; set;}

		[RED("inputApplied")] 		public CBool InputApplied { get; set;}

		[RED("controllable")] 		public CBool Controllable { get; set;}

		[RED("physMAC")] 		public CHandle<CMovingPhysicalAgentComponent> PhysMAC { get; set;}

		[RED("pitchDamp")] 		public CHandle<SpringDamper> PitchDamp { get; set;}

		[RED("localSpaceControlls")] 		public CBool LocalSpaceControlls { get; set;}

		[RED("useSimpleStaminaManagement")] 		public CBool UseSimpleStaminaManagement { get; set;}

		[RED("isInCustomSpot")] 		public CBool IsInCustomSpot { get; set;}

		[RED("ignoreTestsCounter")] 		public CInt32 IgnoreTestsCounter { get; set;}

		[RED("manualControl")] 		public CBool ManualControl { get; set;}

		[RED("canFollowNpc")] 		public CBool CanFollowNpc { get; set;}

		[RED("horseComponentToFollow")] 		public CHandle<W3HorseComponent> HorseComponentToFollow { get; set;}

		[RED("potentiallyWild")] 		public CBool PotentiallyWild { get; set;}

		[RED("canTakeDamageFromFalling")] 		public CBool CanTakeDamageFromFalling { get; set;}

		[RED("mountTestPlayerPos")] 		public Vector MountTestPlayerPos { get; set;}

		[RED("mountTestHorsePos")] 		public Vector MountTestHorsePos { get; set;}

		[RED("mountTestEndPos")] 		public Vector MountTestEndPos { get; set;}

		[RED("mountTestNormal")] 		public Vector MountTestNormal { get; set;}

		[RED("mountTestCollisionGroups", 2,0)] 		public CArray<CName> MountTestCollisionGroups { get; set;}

		[RED("hideHorse")] 		public CBool HideHorse { get; set;}

		[RED("killHorse")] 		public CBool KillHorse { get; set;}

		[RED("isMountableByPlayer")] 		public CBool IsMountableByPlayer { get; set;}

		[RED("horseMount")] 		public CHandle<CComponent> HorseMount { get; set;}

		[RED("cameraMode")] 		public CInt32 CameraMode { get; set;}

		[RED("inWater")] 		public CBool InWater { get; set;}

		[RED("isInIdle")] 		public CBool IsInIdle { get; set;}

		[RED("isInHorseAction")] 		public CBool IsInHorseAction { get; set;}

		[RED("firstSpawn")] 		public CBool FirstSpawn { get; set;}

		[RED("panicDamper")] 		public CHandle<SpringDamper> PanicDamper { get; set;}

		[RED("panicMult")] 		public CFloat PanicMult { get; set;}

		[RED("PANIC_RANGE")] 		public CFloat PANIC_RANGE { get; set;}

		[RED("THREAT_MULT")] 		public CFloat THREAT_MULT { get; set;}

		[RED("staticPanic")] 		public CInt32 StaticPanic { get; set;}

		[RED("frontHit")] 		public CBool FrontHit { get; set;}

		[RED("backHit")] 		public CBool BackHit { get; set;}

		[RED("frontLeg")] 		public Vector FrontLeg { get; set;}

		[RED("backLeg")] 		public Vector BackLeg { get; set;}

		[RED("currentPitch")] 		public CFloat CurrentPitch { get; set;}

		[RED("horseActor")] 		public CHandle<CActor> HorseActor { get; set;}

		[RED("panicVibrate")] 		public CBool PanicVibrate { get; set;}

		[RED("collidedActors", 2,0)] 		public CArray<CollsionActorStruct> CollidedActors { get; set;}

		public W3HorseComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3HorseComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}