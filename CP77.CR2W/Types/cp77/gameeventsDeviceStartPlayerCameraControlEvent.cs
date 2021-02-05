using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeviceStartPlayerCameraControlEvent : redEvent
	{
		[Ordinal(0)]  [RED("playerController")] public wCHandle<gameObject> PlayerController { get; set; }
		[Ordinal(1)]  [RED("initialRotation")] public Vector4 InitialRotation { get; set; }
		[Ordinal(2)]  [RED("minYaw")] public CFloat MinYaw { get; set; }
		[Ordinal(3)]  [RED("maxYaw")] public CFloat MaxYaw { get; set; }
		[Ordinal(4)]  [RED("minPitch")] public CFloat MinPitch { get; set; }
		[Ordinal(5)]  [RED("maxPitch")] public CFloat MaxPitch { get; set; }

		public gameeventsDeviceStartPlayerCameraControlEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
