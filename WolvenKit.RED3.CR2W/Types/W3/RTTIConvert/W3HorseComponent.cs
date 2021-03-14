using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3HorseComponent : CVehicleComponent
	{
		[Ordinal(1)] [RED("riderSharedParams")] 		public CHandle<CHorseRiderSharedParams> RiderSharedParams { get; set;}

		[Ordinal(2)] [RED("lastRider")] 		public CHandle<CActor> LastRider { get; set;}

		[Ordinal(3)] [RED("originalAttitudeGroup")] 		public CName OriginalAttitudeGroup { get; set;}

		[Ordinal(4)] [RED("canDismount")] 		public CBool CanDismount { get; set;}

		[Ordinal(5)] [RED("inCanter")] 		public CBool InCanter { get; set;}

		[Ordinal(6)] [RED("inGallop")] 		public CBool InGallop { get; set;}

		[Ordinal(7)] [RED("inputApplied")] 		public CBool InputApplied { get; set;}

		[Ordinal(8)] [RED("controllable")] 		public CBool Controllable { get; set;}

		[Ordinal(9)] [RED("physMAC")] 		public CHandle<CMovingPhysicalAgentComponent> PhysMAC { get; set;}

		[Ordinal(10)] [RED("pitchDamp")] 		public CHandle<SpringDamper> PitchDamp { get; set;}

		[Ordinal(11)] [RED("localSpaceControlls")] 		public CBool LocalSpaceControlls { get; set;}

		[Ordinal(12)] [RED("useSimpleStaminaManagement")] 		public CBool UseSimpleStaminaManagement { get; set;}

		[Ordinal(13)] [RED("isInCustomSpot")] 		public CBool IsInCustomSpot { get; set;}

		[Ordinal(14)] [RED("ignoreTestsCounter")] 		public CInt32 IgnoreTestsCounter { get; set;}

		[Ordinal(15)] [RED("manualControl")] 		public CBool ManualControl { get; set;}

		[Ordinal(16)] [RED("canFollowNpc")] 		public CBool CanFollowNpc { get; set;}

		[Ordinal(17)] [RED("horseComponentToFollow")] 		public CHandle<W3HorseComponent> HorseComponentToFollow { get; set;}

		[Ordinal(18)] [RED("potentiallyWild")] 		public CBool PotentiallyWild { get; set;}

		[Ordinal(19)] [RED("canTakeDamageFromFalling")] 		public CBool CanTakeDamageFromFalling { get; set;}

		[Ordinal(20)] [RED("mountTestPlayerPos")] 		public Vector MountTestPlayerPos { get; set;}

		[Ordinal(21)] [RED("mountTestHorsePos")] 		public Vector MountTestHorsePos { get; set;}

		[Ordinal(22)] [RED("mountTestEndPos")] 		public Vector MountTestEndPos { get; set;}

		[Ordinal(23)] [RED("mountTestNormal")] 		public Vector MountTestNormal { get; set;}

		[Ordinal(24)] [RED("mountTestCollisionGroups", 2,0)] 		public CArray<CName> MountTestCollisionGroups { get; set;}

		[Ordinal(25)] [RED("hideHorse")] 		public CBool HideHorse { get; set;}

		[Ordinal(26)] [RED("killHorse")] 		public CBool KillHorse { get; set;}

		[Ordinal(27)] [RED("isMountableByPlayer")] 		public CBool IsMountableByPlayer { get; set;}

		[Ordinal(28)] [RED("horseMount")] 		public CHandle<CComponent> HorseMount { get; set;}

		[Ordinal(29)] [RED("cameraMode")] 		public CInt32 CameraMode { get; set;}

		[Ordinal(30)] [RED("inWater")] 		public CBool InWater { get; set;}

		[Ordinal(31)] [RED("isInIdle")] 		public CBool IsInIdle { get; set;}

		[Ordinal(32)] [RED("isInHorseAction")] 		public CBool IsInHorseAction { get; set;}

		[Ordinal(33)] [RED("firstSpawn")] 		public CBool FirstSpawn { get; set;}

		[Ordinal(34)] [RED("panicDamper")] 		public CHandle<SpringDamper> PanicDamper { get; set;}

		[Ordinal(35)] [RED("panicMult")] 		public CFloat PanicMult { get; set;}

		[Ordinal(36)] [RED("PANIC_RANGE")] 		public CFloat PANIC_RANGE { get; set;}

		[Ordinal(37)] [RED("THREAT_MULT")] 		public CFloat THREAT_MULT { get; set;}

		[Ordinal(38)] [RED("staticPanic")] 		public CInt32 StaticPanic { get; set;}

		[Ordinal(39)] [RED("frontHit")] 		public CBool FrontHit { get; set;}

		[Ordinal(40)] [RED("backHit")] 		public CBool BackHit { get; set;}

		[Ordinal(41)] [RED("frontLeg")] 		public Vector FrontLeg { get; set;}

		[Ordinal(42)] [RED("backLeg")] 		public Vector BackLeg { get; set;}

		[Ordinal(43)] [RED("currentPitch")] 		public CFloat CurrentPitch { get; set;}

		[Ordinal(44)] [RED("horseActor")] 		public CHandle<CActor> HorseActor { get; set;}

		[Ordinal(45)] [RED("panicVibrate")] 		public CBool PanicVibrate { get; set;}

		[Ordinal(46)] [RED("collidedActors", 2,0)] 		public CArray<CollsionActorStruct> CollidedActors { get; set;}

		public W3HorseComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3HorseComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}