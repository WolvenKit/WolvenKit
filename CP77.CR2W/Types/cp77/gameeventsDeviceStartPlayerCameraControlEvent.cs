using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeviceStartPlayerCameraControlEvent : redEvent
	{
		[Ordinal(0)]  [RED("initialRotation")] public Vector4 InitialRotation { get; set; }
		[Ordinal(1)]  [RED("maxPitch")] public CFloat MaxPitch { get; set; }
		[Ordinal(2)]  [RED("maxYaw")] public CFloat MaxYaw { get; set; }
		[Ordinal(3)]  [RED("minPitch")] public CFloat MinPitch { get; set; }
		[Ordinal(4)]  [RED("minYaw")] public CFloat MinYaw { get; set; }
		[Ordinal(5)]  [RED("playerController")] public wCHandle<gameObject> PlayerController { get; set; }

		public gameeventsDeviceStartPlayerCameraControlEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
