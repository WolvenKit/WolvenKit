using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TaskTeleportActionDef : IBehTreeTaskDefinition
	{
		[RED("setIsTeleportingFlag")] 		public CBool SetIsTeleportingFlag { get; set;}

		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("minDistanceFromLastPosition")] 		public CFloat MinDistanceFromLastPosition { get; set;}

		[RED("teleportToActorHeading")] 		public CBool TeleportToActorHeading { get; set;}

		[RED("teleportAwayFromActorHeading")] 		public CBool TeleportAwayFromActorHeading { get; set;}

		[RED("teleportInFrontOfTarget")] 		public CBool TeleportInFrontOfTarget { get; set;}

		[RED("teleportInFrontOfOwner")] 		public CBool TeleportInFrontOfOwner { get; set;}

		[RED("requestedFacingDirectionNoiseAngle")] 		public CFloat RequestedFacingDirectionNoiseAngle { get; set;}

		[RED("teleportBehindTarget")] 		public CBool TeleportBehindTarget { get; set;}

		[RED("teleportOutsidePlayerFOV")] 		public CBool TeleportOutsidePlayerFOV { get; set;}

		[RED("teleportWithinPlayerFOV")] 		public CBool TeleportWithinPlayerFOV { get; set;}

		[RED("teleportType")] 		public CEnum<ETeleportType> TeleportType { get; set;}

		[RED("minWaterDepthToAppear")] 		public CFloat MinWaterDepthToAppear { get; set;}

		[RED("maxWaterDepthToAppear")] 		public CFloat MaxWaterDepthToAppear { get; set;}

		[RED("zTolerance")] 		public CFloat ZTolerance { get; set;}

		[RED("rotateToTarget")] 		public CBool RotateToTarget { get; set;}

		[RED("testLOSforNewPosition")] 		public CBool TestLOSforNewPosition { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("testNavigationBetweenCombatTargetAndNewPosition")] 		public CBool TestNavigationBetweenCombatTargetAndNewPosition { get; set;}

		[RED("overrideActorRadiusForNavigationTests")] 		public CBool OverrideActorRadiusForNavigationTests { get; set;}

		[RED("actorRadiusForNavigationTests")] 		public CFloat ActorRadiusForNavigationTests { get; set;}

		[RED("checkWaterLevel")] 		public CBool CheckWaterLevel { get; set;}

		[RED("searchingTimeout")] 		public CFloat SearchingTimeout { get; set;}

		[RED("nodeTag")] 		public CName NodeTag { get; set;}

		[RED("shouldSpawnMarkers")] 		public CBool ShouldSpawnMarkers { get; set;}

		[RED("setInvulnerable")] 		public CBool SetInvulnerable { get; set;}

		[RED("dontTeleportOutsideGuardArea")] 		public CBool DontTeleportOutsideGuardArea { get; set;}

		[RED("minDistanceFromEnititesWithTag")] 		public CName MinDistanceFromEnititesWithTag { get; set;}

		[RED("minDistanceFromTaggedEntities")] 		public CFloat MinDistanceFromTaggedEntities { get; set;}

		public TaskTeleportActionDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new TaskTeleportActionDef(cr2w);

	}
}