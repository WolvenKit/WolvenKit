using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CollisionTrajectory : CGameplayEntity
	{
		[Ordinal(1)] [RED("stateManager")] 		public CHandle<CExplorationStateManager> StateManager { get; set;}

		[Ordinal(2)] [RED("collisionSegmentsArr", 2,0)] 		public CArray<CHandle<CollisionTrajectoryPart>> CollisionSegmentsArr { get; set;}

		[Ordinal(3)] [RED("firstSegmentCollision")] 		public CEnum<ECollisionTrajectoryPart> FirstSegmentCollision { get; set;}

		[Ordinal(4)] [RED("trajectoryStatusLastChecked")] 		public CEnum<ECollisionTrajecoryStatus> TrajectoryStatusLastChecked { get; set;}

		[Ordinal(5)] [RED("trajecoryExpStatusLastChecked")] 		public CEnum<ECollisionTrajecoryExplorationStatus> TrajecoryExpStatusLastChecked { get; set;}

		[Ordinal(6)] [RED("goingToWaterLastState")] 		public CEnum<ECollisionTrajectoryToWaterState> GoingToWaterLastState { get; set;}

		[Ordinal(7)] [RED("computedCollisionState")] 		public CBool ComputedCollisionState { get; set;}

		[Ordinal(8)] [RED("computedGoingToWater")] 		public CBool ComputedGoingToWater { get; set;}

		public CollisionTrajectory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CollisionTrajectory(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}