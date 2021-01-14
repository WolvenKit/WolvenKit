using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkTextOffsetAnimationController : inkTextAnimationController
	{
		[Ordinal(0)]  [RED("timeToSkip")] public CFloat TimeToSkip { get; set; }

		public inkTextOffsetAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
