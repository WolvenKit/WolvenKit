using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("cameraNearPlane")] public CFloat CameraNearPlane { get; set; }
		[Ordinal(3)] [RED("cameraFarPlane")] public CFloat CameraFarPlane { get; set; }
		[Ordinal(4)] [RED("automated")] public CBool Automated { get; set; }
		[Ordinal(5)] [RED("ISO")] public CUInt32 ISO { get; set; }
		[Ordinal(6)] [RED("shutterTime")] public CFloat ShutterTime { get; set; }
		[Ordinal(7)] [RED("fStop")] public CFloat FStop { get; set; }

		public CameraAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
