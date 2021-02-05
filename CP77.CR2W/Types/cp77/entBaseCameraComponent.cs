using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entBaseCameraComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("weaponPlane")] public SWeaponPlaneParams WeaponPlane { get; set; }
		[Ordinal(1)]  [RED("fov")] public CFloat Fov { get; set; }
		[Ordinal(2)]  [RED("zoom")] public CFloat Zoom { get; set; }
		[Ordinal(3)]  [RED("nearPlaneOverride")] public CFloat NearPlaneOverride { get; set; }
		[Ordinal(4)]  [RED("farPlaneOverride")] public CFloat FarPlaneOverride { get; set; }
		[Ordinal(5)]  [RED("motionBlurScale")] public CFloat MotionBlurScale { get; set; }

		public entBaseCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
