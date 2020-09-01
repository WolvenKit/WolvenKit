using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMetalinkComponent : CWayPointComponent
	{
		[Ordinal(0)] [RED("aiAction")] 		public CHandle<IAIExplorationTree> AiAction { get; set;}

		[Ordinal(0)] [RED("pathfindingCostMultiplier")] 		public CFloat PathfindingCostMultiplier { get; set;}

		[Ordinal(0)] [RED("destinationEntityTag")] 		public CName DestinationEntityTag { get; set;}

		[Ordinal(0)] [RED("destinationWaypointComponent")] 		public CString DestinationWaypointComponent { get; set;}

		[Ordinal(0)] [RED("internalObstacleEntity")] 		public EntityHandle InternalObstacleEntity { get; set;}

		[Ordinal(0)] [RED("internalObstacleComponent")] 		public CString InternalObstacleComponent { get; set;}

		[Ordinal(0)] [RED("useInternalObstacle")] 		public CBool UseInternalObstacle { get; set;}

		[Ordinal(0)] [RED("enabledByDefault")] 		public CBool EnabledByDefault { get; set;}

		[Ordinal(0)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(0)] [RED("isGhostLink")] 		public CBool IsGhostLink { get; set;}

		[Ordinal(0)] [RED("questTrackingPortal")] 		public CBool QuestTrackingPortal { get; set;}

		public CMetalinkComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMetalinkComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}