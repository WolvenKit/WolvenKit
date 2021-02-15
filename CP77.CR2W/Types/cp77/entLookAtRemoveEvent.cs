using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entLookAtRemoveEvent : redEvent
	{
		[Ordinal(0)] [RED("lookAtRef")] public animLookAtRef LookAtRef { get; set; }
		[Ordinal(1)] [RED("hasOutTransition")] public CBool HasOutTransition { get; set; }
		[Ordinal(2)] [RED("outTransitionSpeed")] public CFloat OutTransitionSpeed { get; set; }

		public entLookAtRemoveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
