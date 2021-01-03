using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CameraAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("ISO")] public CUInt32 ISO { get; set; }
		[Ordinal(1)]  [RED("automated")] public CBool Automated { get; set; }
		[Ordinal(2)]  [RED("cameraFarPlane")] public CFloat CameraFarPlane { get; set; }
		[Ordinal(3)]  [RED("cameraNearPlane")] public CFloat CameraNearPlane { get; set; }
		[Ordinal(4)]  [RED("fStop")] public CFloat FStop { get; set; }
		[Ordinal(5)]  [RED("shutterTime")] public CFloat ShutterTime { get; set; }

		public CameraAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
