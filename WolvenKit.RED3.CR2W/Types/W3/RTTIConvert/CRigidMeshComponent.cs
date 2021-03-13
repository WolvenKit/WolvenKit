using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CRigidMeshComponent : CStaticMeshComponent
	{
		[Ordinal(1)] [RED("motionType")] 		public CEnum<EMotionType> MotionType { get; set;}

		[Ordinal(2)] [RED("linearDamping")] 		public CFloat LinearDamping { get; set;}

		[Ordinal(3)] [RED("angularDamping")] 		public CFloat AngularDamping { get; set;}

		[Ordinal(4)] [RED("linearVelocityClamp")] 		public CFloat LinearVelocityClamp { get; set;}

		public CRigidMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CRigidMeshComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}