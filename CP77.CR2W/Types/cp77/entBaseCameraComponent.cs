using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entBaseCameraComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("farPlaneOverride")] public CFloat FarPlaneOverride { get; set; }
		[Ordinal(1)]  [RED("fov")] public CFloat Fov { get; set; }
		[Ordinal(2)]  [RED("motionBlurScale")] public CFloat MotionBlurScale { get; set; }
		[Ordinal(3)]  [RED("nearPlaneOverride")] public CFloat NearPlaneOverride { get; set; }
		[Ordinal(4)]  [RED("zoom")] public CFloat Zoom { get; set; }

		public entBaseCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
