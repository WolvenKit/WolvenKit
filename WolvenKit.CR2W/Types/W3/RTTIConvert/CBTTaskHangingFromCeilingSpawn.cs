using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskHangingFromCeilingSpawn : CBTTaskPlayAnimationEventDecorator
	{
		[RED("availableOnBehVarName")] 		public CName AvailableOnBehVarName { get; set;}

		[RED("availableOnBehVarValue")] 		public CFloat AvailableOnBehVarValue { get; set;}

		[RED("spawnOnHit")] 		public CBool SpawnOnHit { get; set;}

		[RED("spawnOnDistanceToHostile")] 		public CFloat SpawnOnDistanceToHostile { get; set;}

		[RED("spawnOnGameplayEventName")] 		public CName SpawnOnGameplayEventName { get; set;}

		[RED("spawnOnAnimEventName")] 		public CName SpawnOnAnimEventName { get; set;}

		[RED("traceToCeiling")] 		public CBool TraceToCeiling { get; set;}

		[RED("verticalAdjustment")] 		public CBool VerticalAdjustment { get; set;}

		[RED("horizontalAdjustment")] 		public CBool HorizontalAdjustment { get; set;}

		[RED("manageGravity")] 		public CBool ManageGravity { get; set;}

		[RED("manageCollision")] 		public CBool ManageCollision { get; set;}

		[RED("reenableCollisionAfter")] 		public CFloat ReenableCollisionAfter { get; set;}

		[RED("setCustomMovement")] 		public CBool SetCustomMovement { get; set;}

		[RED("raiseEvent")] 		public CName RaiseEvent { get; set;}

		[RED("timeOfInitialPosCorrection")] 		public CFloat TimeOfInitialPosCorrection { get; set;}

		[RED("reuseInitialSpawnPosition")] 		public CBool ReuseInitialSpawnPosition { get; set;}

		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("raisedEvent")] 		public CBool RaisedEvent { get; set;}

		[RED("slideEventReceived")] 		public CBool SlideEventReceived { get; set;}

		[RED("actorPos")] 		public Vector ActorPos { get; set;}

		[RED("initialPos")] 		public Vector InitialPos { get; set;}

		[RED("animInfoCache")] 		public SAnimationEventAnimInfo AnimInfoCache { get; set;}

		[RED("collisionGroups", 2,0)] 		public CArray<CName> CollisionGroups { get; set;}

		public CBTTaskHangingFromCeilingSpawn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskHangingFromCeilingSpawn(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}