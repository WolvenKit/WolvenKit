using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnCameraAnimationRid : CVariable
	{
		[Ordinal(0)]  [RED("animation")] public CHandle<animIAnimationBuffer> Animation { get; set; }
		[Ordinal(1)]  [RED("tag")] public scnRidTag Tag { get; set; }

		public scnCameraAnimationRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
