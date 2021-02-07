using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CameraAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("cameraNearPlane")] public CFloat CameraNearPlane { get; set; }
		[Ordinal(1)]  [RED("cameraFarPlane")] public CFloat CameraFarPlane { get; set; }
		[Ordinal(2)]  [RED("automated")] public CBool Automated { get; set; }
		[Ordinal(3)]  [RED("ISO")] public CUInt32 ISO { get; set; }
		[Ordinal(4)]  [RED("shutterTime")] public CFloat ShutterTime { get; set; }
		[Ordinal(5)]  [RED("fStop")] public CFloat FStop { get; set; }

		public CameraAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
