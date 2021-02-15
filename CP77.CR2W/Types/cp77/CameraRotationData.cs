using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CameraRotationData : CVariable
	{
		[Ordinal(0)] [RED("pitch")] public CFloat Pitch { get; set; }
		[Ordinal(1)] [RED("maxPitch")] public CFloat MaxPitch { get; set; }
		[Ordinal(2)] [RED("minPitch")] public CFloat MinPitch { get; set; }
		[Ordinal(3)] [RED("yaw")] public CFloat Yaw { get; set; }
		[Ordinal(4)] [RED("maxYaw")] public CFloat MaxYaw { get; set; }
		[Ordinal(5)] [RED("minYaw")] public CFloat MinYaw { get; set; }

		public CameraRotationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
