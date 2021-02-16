using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PreloadAnimationsEvent : redEvent
	{
		[Ordinal(0)] [RED("streamingContextName")] public CName StreamingContextName { get; set; }
		[Ordinal(1)] [RED("highPriority")] public CBool HighPriority { get; set; }

		public PreloadAnimationsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
