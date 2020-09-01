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
		[Ordinal(0)] [RED("("riderSharedParams")] 		public CHandle<CHorseRiderSharedParams> RiderSharedParams { get; set;}

		[Ordinal(0)] [RED("("lastRider")] 		public CHandle<CActor> LastRider { get; set;}

		[Ordinal(0)] [RED("("originalAttitudeGroup")] 		public CName OriginalAttitudeGroup { get; set;}

		[Ordinal(0)] [RED("("canDismount")] 		public CBool CanDismount { get; set;}

		[Ordinal(0)] [RED("("inCanter")] 		public CBool InCanter { get; set;}

		[Ordinal(0)] [RED("("inGallop")] 		public CBool InGallop { get; set;}

		[Ordinal(0)] [RED("("inputApplied")] 		public CBool InputApplied { get; set;}

		[Ordinal(0)] [RED("("controllable")] 		public CBool Controllable { get; set;}

		[Ordinal(0)] [RED("("physMAC")] 		public CHandle<CMovingPhysicalAgentComponent> PhysMAC { get; set;}

		[Ordinal(0)] [RED("("pitchDamp")] 		public CHandle<SpringDamper> PitchDamp { get; set;}

		[Ordinal(0)] [RED("("localSpaceControlls")] 		public CBool LocalSpaceControlls { get; set;}

		[Ordinal(0)] [RED("("useSimpleStaminaManagement")] 		public CBool UseSimpleStaminaManagement { get; set;}

		[Ordinal(0)] [RED("("isInCustomSpot")] 		public CBool IsInCustomSpot { get; set;}

		[Ordinal(0)] [RED("("ignoreTestsCounter")] 		public CInt32 IgnoreTestsCounter { get; set;}

		[Ordinal(0)] [RED("("manualControl")] 		public CBool ManualControl { get; set;}

		[Ordinal(0)] [RED("("canFollowNpc")] 		public CBool CanFollowNpc { get; set;}

		[Ordinal(0)] [RED("("horseComponentToFollow")] 		public CHandle<W3HorseComponent> HorseComponentToFollow { get; set;}

		[Ordinal(0)] [RED("("potentiallyWild")] 		public CBool PotentiallyWild { get; set;}

		[Ordinal(0)] [RED("("canTakeDamageFromFalling")] 		public CBool CanTakeDamageFromFalling { get; set;}

		[Ordinal(0)] [RED("("mountTestPlayerPos")] 		public Vector MountTestPlayerPos { get; set;}

		[Ordinal(0)] [RED("("mountTestHorsePos")] 		public Vector MountTestHorsePos { get; set;}

		[Ordinal(0)] [RED("("mountTestEndPos")] 		public Vector MountTestEndPos { get; set;}

		[Ordinal(0)] [RED("("mountTestNormal")] 		public Vector MountTestNormal { get; set;}

		[Ordinal(0)] [RED("("mountTestCollisionGroups", 2,0)] 		public CArray<CName> MountTestCollisionGroups { get; set;}

		[Ordinal(0)] [RED("("hideHorse")] 		public CBool HideHorse { get; set;}

		[Ordinal(0)] [RED("("killHorse")] 		public CBool KillHorse { get; set;}

		[Ordinal(0)] [RED("("isMountableByPlayer")] 		public CBool IsMountableByPlayer { get; set;}

		[Ordinal(0)] [RED("("horseMount")] 		public CHandle<CComponent> HorseMount { get; set;}

		[Ordinal(0)] [RED("("cameraMode")] 		public CInt32 CameraMode { get; set;}

		[Ordinal(0)] [RED("("inWater")] 		public CBool InWater { get; set;}

		[Ordinal(0)] [RED("("isInIdle")] 		public CBool IsInIdle { get; set;}

		[Ordinal(0)] [RED("("isInHorseAction")] 		public CBool IsInHorseAction { get; set;}

		[Ordinal(0)] [RED("("firstSpawn")] 		public CBool FirstSpawn { get; set;}

		[Ordinal(0)] [RED("("panicDamper")] 		public CHandle<SpringDamper> PanicDamper { get; set;}

		[Ordinal(0)] [RED("("panicMult")] 		public CFloat PanicMult { get; set;}

		[Ordinal(0)] [RED("("PANIC_RANGE")] 		public CFloat PANIC_RANGE { get; set;}

		[Ordinal(0)] [RED("("THREAT_MULT")] 		public CFloat THREAT_MULT { get; set;}

		[Ordinal(0)] [RED("("staticPanic")] 		public CInt32 StaticPanic { get; set;}

		[Ordinal(0)] [RED("("frontHit")] 		public CBool FrontHit { get; set;}

		[Ordinal(0)] [RED("("backHit")] 		public CBool BackHit { get; set;}

		[Ordinal(0)] [RED("("frontLeg")] 		public Vector FrontLeg { get; set;}

		[Ordinal(0)] [RED("("backLeg")] 		public Vector BackLeg { get; set;}

		[Ordinal(0)] [RED("("currentPitch")] 		public CFloat CurrentPitch { get; set;}

		[Ordinal(0)] [RED("("horseActor")] 		public CHandle<CActor> HorseActor { get; set;}

		[Ordinal(0)] [RED("("panicVibrate")] 		public CBool PanicVibrate { get; set;}

		[Ordinal(0)] [RED("("collidedActors", 2,0)] 		public CArray<CollsionActorStruct> CollidedActors { get; set;}

		public W3HorseComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3HorseComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}