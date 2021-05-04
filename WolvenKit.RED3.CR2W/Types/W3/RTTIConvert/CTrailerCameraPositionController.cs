using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTrailerCameraPositionController : ICustomCameraPositionController
	{
		[Ordinal(1)] [RED("defaultPitch")] 		public CFloat DefaultPitch { get; set;}

		[Ordinal(2)] [RED("defaultZOffset")] 		public CFloat DefaultZOffset { get; set;}

		[Ordinal(3)] [RED("offsetSmoothTime")] 		public CFloat OffsetSmoothTime { get; set;}

		[Ordinal(4)] [RED("collisionController")] 		public CPtr<ICustomCameraCollisionController> CollisionController { get; set;}

		[Ordinal(5)] [RED("defaultCollisionOriginOffset")] 		public Vector DefaultCollisionOriginOffset { get; set;}

		public CTrailerCameraPositionController(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}