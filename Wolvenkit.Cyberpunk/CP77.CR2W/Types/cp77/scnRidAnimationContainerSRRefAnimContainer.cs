using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimationContainerSRRefAnimContainer : CVariable
	{
		[Ordinal(0)]  [RED("animation")] public scnRidAnimationSRRefId Animation { get; set; }
		[Ordinal(1)]  [RED("context")] public scnRidAnimationContainerSRRefAnimContainerContext Context { get; set; }

		public scnRidAnimationContainerSRRefAnimContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
