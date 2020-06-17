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

		[RED("nearPlane")] 		public ENearPlaneDistance NearPlane { get; set;}

		[RED("farPlane")] 		public EFarPlaneDistance FarPlane { get; set;}

		[RED("customClippingPlanes")] 		public SCustomClippingPlanes CustomClippingPlanes { get; set;}

		[RED("aspect")] 		public CFloat Aspect { get; set;}

		[RED("lockAspect")] 		public CBool LockAspect { get; set;}

		[RED("defaultCamera")] 		public CBool DefaultCamera { get; set;}

		public CCameraComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCameraComponent(cr2w);

	}
}