using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CollisionTrajectoryPart : CPhantomComponent
	{
		[Ordinal(1)] [RED("triggeredCollisions")] 		public CInt32 TriggeredCollisions { get; set;}

		[Ordinal(2)] [RED("waterCollisions")] 		public CInt32 WaterCollisions { get; set;}

		[Ordinal(3)] [RED("ownerTrajectory")] 		public CHandle<CollisionTrajectory> OwnerTrajectory { get; set;}

		[Ordinal(4)] [RED("part")] 		public CEnum<ECollisionTrajectoryPart> Part { get; set;}

		[Ordinal(5)] [RED("waterUpPosCheckSlotName")] 		public CName WaterUpPosCheckSlotName { get; set;}

		[Ordinal(6)] [RED("waterDownPosCheckSlotName")] 		public CName WaterDownPosCheckSlotName { get; set;}

		public CollisionTrajectoryPart(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}