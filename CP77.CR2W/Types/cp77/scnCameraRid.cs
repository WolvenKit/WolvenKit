using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnCameraRid : CVariable
	{
		[Ordinal(0)] [RED("tag")] public scnRidTag Tag { get; set; }
		[Ordinal(1)] [RED("animations")] public CArray<scnCameraAnimationRid> Animations { get; set; }

		public scnCameraRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
