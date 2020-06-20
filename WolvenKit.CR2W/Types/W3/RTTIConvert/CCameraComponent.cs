using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraComponent : CSpriteComponent
	{
		[RED("fov")] 		public CFloat Fov { get; set;}

		[RED("nearPlane")] 		public CEnum<ENearPlaneDistance> NearPlane { get; set;}

		[RED("farPlane")] 		public CEnum<EFarPlaneDistance> FarPlane { get; set;}

		[RED("customClippingPlanes")] 		public SCustomClippingPlanes CustomClippingPlanes { get; set;}

		[RED("aspect")] 		public CFloat Aspect { get; set;}

		[RED("lockAspect")] 		public CBool LockAspect { get; set;}

		[RED("defaultCamera")] 		public CBool DefaultCamera { get; set;}

		public CCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}