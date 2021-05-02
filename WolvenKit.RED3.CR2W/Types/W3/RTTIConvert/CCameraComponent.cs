using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraComponent : CSpriteComponent
	{
		[Ordinal(1)] [RED("fov")] 		public CFloat Fov { get; set;}

		[Ordinal(2)] [RED("nearPlane")] 		public CEnum<ENearPlaneDistance> NearPlane { get; set;}

		[Ordinal(3)] [RED("farPlane")] 		public CEnum<EFarPlaneDistance> FarPlane { get; set;}

		[Ordinal(4)] [RED("customClippingPlanes")] 		public SCustomClippingPlanes CustomClippingPlanes { get; set;}

		[Ordinal(5)] [RED("aspect")] 		public CFloat Aspect { get; set;}

		[Ordinal(6)] [RED("lockAspect")] 		public CBool LockAspect { get; set;}

		[Ordinal(7)] [RED("defaultCamera")] 		public CBool DefaultCamera { get; set;}

		public CCameraComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}