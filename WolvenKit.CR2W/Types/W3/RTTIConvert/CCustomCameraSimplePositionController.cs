using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCustomCameraSimplePositionController : ICustomCameraPositionController
	{
		[Ordinal(1)] [RED("collisionController")] 		public CPtr<ICustomCameraCollisionController> CollisionController { get; set;}

		[Ordinal(2)] [RED("collisionController2")] 		public CPtr<ICustomCameraCollisionController> CollisionController2 { get; set;}

		public CCustomCameraSimplePositionController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCustomCameraSimplePositionController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}