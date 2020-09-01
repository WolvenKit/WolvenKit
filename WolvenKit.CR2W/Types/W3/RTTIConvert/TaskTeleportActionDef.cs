using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TaskTeleportActionDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("setIsTeleportingFlag")] 		public CBool SetIsTeleportingFlag { get; set;}

		[Ordinal(0)] [RED("("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(0)] [RED("("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("("minDistanceFromLastPosition")] 		public CFloat MinDistanceFromLastPosition { get; set;}

		[Ordinal(0)] [RED("("teleportToActorHeading")] 		public CBool TeleportToActorHeading { get; set;}

		[Ordinal(0)] [RED("("teleportAwayFromActorHeading")] 		public CBool TeleportAwayFromActorHeading { get; set;}

		[Ordinal(0)] [RED("("teleportInFrontOfTarget")] 		public CBool TeleportInFrontOfTarget { get; set;}

		[Ordinal(0)] [RED("("teleportInFrontOfOwner")] 		public CBool TeleportInFrontOfOwner { get; set;}

		[Ordinal(0)] [RED("("requestedFacingDirectionNoiseAngle")] 		public CFloat RequestedFacingDirectionNoiseAngle { get; set;}

		[Ordinal(0)] [RED("("teleportBehindTarget")] 		public CBool TeleportBehindTarget { get; set;}

		[Ordinal(0)] [RED("("teleportOutsidePlayerFOV")] 		public CBool TeleportOutsidePlayerFOV { get; set;}

		[Ordinal(0)] [RED("("teleportWithinPlayerFOV")] 		public CBool TeleportWithinPlayerFOV { get; set;}

		[Ordinal(0)] [RED("("teleportType")] 		public CEnum<ETeleportType> TeleportType { get; set;}

		[Ordinal(0)] [RED("("minWaterDepthToAppear")] 		public CFloat MinWaterDepthToAppear { get; set;}

		[Ordinal(0)] [RED("("maxWaterDepthToAppear")] 		public CFloat MaxWaterDepthToAppear { get; set;}

		[Ordinal(0)] [RED("("zTolerance")] 		public CFloat ZTolerance { get; set;}

		[Ordinal(0)] [RED("("rotateToTarget")] 		public CBool RotateToTarget { get; set;}

		[Ordinal(0)] [RED("("testLOSforNewPosition")] 		public CBool TestLOSforNewPosition { get; set;}

		[Ordinal(0)] [RED("("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(0)] [RED("("testNavigationBetweenCombatTargetAndNewPosition")] 		public CBool TestNavigationBetweenCombatTargetAndNewPosition { get; set;}

		[Ordinal(0)] [RED("("overrideActorRadiusForNavigationTests")] 		public CBool OverrideActorRadiusForNavigationTests { get; set;}

		[Ordinal(0)] [RED("("actorRadiusForNavigationTests")] 		public CFloat ActorRadiusForNavigationTests { get; set;}

		[Ordinal(0)] [RED("("checkWaterLevel")] 		public CBool CheckWaterLevel { get; set;}

		[Ordinal(0)] [RED("("searchingTimeout")] 		public CFloat SearchingTimeout { get; set;}

		[Ordinal(0)] [RED("("nodeTag")] 		public CName NodeTag { get; set;}

		[Ordinal(0)] [RED("("shouldSpawnMarkers")] 		public CBool ShouldSpawnMarkers { get; set;}

		[Ordinal(0)] [RED("("setInvulnerable")] 		public CBool SetInvulnerable { get; set;}

		[Ordinal(0)] [RED("("dontTeleportOutsideGuardArea")] 		public CBool DontTeleportOutsideGuardArea { get; set;}

		[Ordinal(0)] [RED("("minDistanceFromEnititesWithTag")] 		public CName MinDistanceFromEnititesWithTag { get; set;}

		[Ordinal(0)] [RED("("minDistanceFromTaggedEntities")] 		public CFloat MinDistanceFromTaggedEntities { get; set;}

		public TaskTeleportActionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TaskTeleportActionDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}