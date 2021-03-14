using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TaskTeleportAction : IBehTreeTask
	{
		[Ordinal(1)] [RED("teleportType")] 		public CEnum<ETeleportType> TeleportType { get; set;}

		[Ordinal(2)] [RED("teleportToActorHeading")] 		public CBool TeleportToActorHeading { get; set;}

		[Ordinal(3)] [RED("teleportAwayFromActorHeading")] 		public CBool TeleportAwayFromActorHeading { get; set;}

		[Ordinal(4)] [RED("teleportInFrontOfTarget")] 		public CBool TeleportInFrontOfTarget { get; set;}

		[Ordinal(5)] [RED("teleportInFrontOfOwner")] 		public CBool TeleportInFrontOfOwner { get; set;}

		[Ordinal(6)] [RED("teleportOutsidePlayerFOV")] 		public CBool TeleportOutsidePlayerFOV { get; set;}

		[Ordinal(7)] [RED("teleportWithinPlayerFOV")] 		public CBool TeleportWithinPlayerFOV { get; set;}

		[Ordinal(8)] [RED("teleportBehindTarget")] 		public CBool TeleportBehindTarget { get; set;}

		[Ordinal(9)] [RED("requestedFacingDirectionNoiseAngle")] 		public CFloat RequestedFacingDirectionNoiseAngle { get; set;}

		[Ordinal(10)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(11)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(12)] [RED("minDistanceFromLastPosition")] 		public CFloat MinDistanceFromLastPosition { get; set;}

		[Ordinal(13)] [RED("setIsTeleportingFlag")] 		public CBool SetIsTeleportingFlag { get; set;}

		[Ordinal(14)] [RED("minWaterDepthToAppear")] 		public CFloat MinWaterDepthToAppear { get; set;}

		[Ordinal(15)] [RED("maxWaterDepthToAppear")] 		public CFloat MaxWaterDepthToAppear { get; set;}

		[Ordinal(16)] [RED("zTolerance")] 		public CFloat ZTolerance { get; set;}

		[Ordinal(17)] [RED("rotateToTarget")] 		public CBool RotateToTarget { get; set;}

		[Ordinal(18)] [RED("testLOSforNewPosition")] 		public CBool TestLOSforNewPosition { get; set;}

		[Ordinal(19)] [RED("testNavigationBetweenCombatTargetAndNewPosition")] 		public CBool TestNavigationBetweenCombatTargetAndNewPosition { get; set;}

		[Ordinal(20)] [RED("overrideActorRadiusForNavigationTests")] 		public CBool OverrideActorRadiusForNavigationTests { get; set;}

		[Ordinal(21)] [RED("actorRadiusForNavigationTests")] 		public CFloat ActorRadiusForNavigationTests { get; set;}

		[Ordinal(22)] [RED("checkWaterLevel")] 		public CBool CheckWaterLevel { get; set;}

		[Ordinal(23)] [RED("searchingTimeout")] 		public CFloat SearchingTimeout { get; set;}

		[Ordinal(24)] [RED("nodeTag")] 		public CName NodeTag { get; set;}

		[Ordinal(25)] [RED("shouldSpawnMarkers")] 		public CBool ShouldSpawnMarkers { get; set;}

		[Ordinal(26)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(27)] [RED("paramsOverriden")] 		public CBool ParamsOverriden { get; set;}

		[Ordinal(28)] [RED("cashedBool")] 		public CBool CashedBool { get; set;}

		[Ordinal(29)] [RED("setInvulnerable")] 		public CBool SetInvulnerable { get; set;}

		[Ordinal(30)] [RED("dontTeleportOutsideGuardArea")] 		public CBool DontTeleportOutsideGuardArea { get; set;}

		[Ordinal(31)] [RED("minDistanceFromEnititesWithTag")] 		public CName MinDistanceFromEnititesWithTag { get; set;}

		[Ordinal(32)] [RED("minDistanceFromTaggedEntities")] 		public CFloat MinDistanceFromTaggedEntities { get; set;}

		[Ordinal(33)] [RED("alreadyTeleported")] 		public CBool AlreadyTeleported { get; set;}

		[Ordinal(34)] [RED("isTeleporting")] 		public CBool IsTeleporting { get; set;}

		[Ordinal(35)] [RED("distFromLastTelePos")] 		public CFloat DistFromLastTelePos { get; set;}

		[Ordinal(36)] [RED("dangerZone")] 		public CFloat DangerZone { get; set;}

		[Ordinal(37)] [RED("angle")] 		public CFloat Angle { get; set;}

		[Ordinal(38)] [RED("lastTelePos")] 		public Vector LastTelePos { get; set;}

		[Ordinal(39)] [RED("lastPos")] 		public Vector LastPos { get; set;}

		[Ordinal(40)] [RED("guardArea")] 		public CHandle<CAreaComponent> GuardArea { get; set;}

		public TaskTeleportAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TaskTeleportAction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}