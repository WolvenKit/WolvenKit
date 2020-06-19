using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CollisionTrajectoryPart : CPhantomComponent
	{
		[RED("part")] 		public CEnum<ECollisionTrajectoryPart> Part { get; set;}

		[RED("waterUpPosCheckSlotName")] 		public CName WaterUpPosCheckSlotName { get; set;}

		[RED("waterDownPosCheckSlotName")] 		public CName WaterDownPosCheckSlotName { get; set;}

		public CollisionTrajectoryPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CollisionTrajectoryPart(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}