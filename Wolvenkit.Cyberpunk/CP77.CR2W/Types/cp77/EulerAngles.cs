using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EulerAngles : CVariable
	{
		[Ordinal(0)]  [RED("Pitch")] public CFloat Pitch { get; set; }
		[Ordinal(1)]  [RED("Roll")] public CFloat Roll { get; set; }
		[Ordinal(2)]  [RED("Yaw")] public CFloat Yaw { get; set; }

		public EulerAngles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
