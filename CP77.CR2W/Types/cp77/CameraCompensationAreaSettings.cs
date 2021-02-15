using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CameraCompensationAreaSettings : CVariable
	{
		[Ordinal(0)] [RED("automated")] public CBool Automated { get; set; }
		[Ordinal(1)] [RED("ISO")] public CUInt32 ISO { get; set; }
		[Ordinal(2)] [RED("shutterTime")] public CFloat ShutterTime { get; set; }
		[Ordinal(3)] [RED("fStop")] public CFloat FStop { get; set; }

		public CameraCompensationAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
