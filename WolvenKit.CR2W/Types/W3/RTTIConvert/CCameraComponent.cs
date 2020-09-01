using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraComponent : CSpriteComponent
	{
		[Ordinal(0)] [RED("("fov")] 		public CFloat Fov { get; set;}

		[Ordinal(0)] [RED("("nearPlane")] 		public CEnum<ENearPlaneDistance> NearPlane { get; set;}

		[Ordinal(0)] [RED("("farPlane")] 		public CEnum<EFarPlaneDistance> FarPlane { get; set;}

		[Ordinal(0)] [RED("("customClippingPlanes")] 		public SCustomClippingPlanes CustomClippingPlanes { get; set;}

		[Ordinal(0)] [RED("("aspect")] 		public CFloat Aspect { get; set;}

		[Ordinal(0)] [RED("("lockAspect")] 		public CBool LockAspect { get; set;}

		[Ordinal(0)] [RED("("defaultCamera")] 		public CBool DefaultCamera { get; set;}

		public CCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}