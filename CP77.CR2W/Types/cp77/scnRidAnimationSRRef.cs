using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimationSRRef : CVariable
	{
		[Ordinal(0)]  [RED("animationSN")] public scnRidSerialNumber AnimationSN { get; set; }
		[Ordinal(1)]  [RED("resourceId")] public scnRidResourceId ResourceId { get; set; }

		public scnRidAnimationSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
