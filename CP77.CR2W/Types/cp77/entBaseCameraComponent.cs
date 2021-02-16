using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entBaseCameraComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("fov")] public CFloat Fov { get; set; }
		[Ordinal(6)] [RED("zoom")] public CFloat Zoom { get; set; }
		[Ordinal(7)] [RED("nearPlaneOverride")] public CFloat NearPlaneOverride { get; set; }
		[Ordinal(8)] [RED("farPlaneOverride")] public CFloat FarPlaneOverride { get; set; }
		[Ordinal(9)] [RED("motionBlurScale")] public CFloat MotionBlurScale { get; set; }

		public entBaseCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
