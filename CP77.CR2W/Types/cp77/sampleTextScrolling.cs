using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleTextScrolling : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("scrollingText")] public inkTextWidgetReference ScrollingText { get; set; }
		[Ordinal(2)] [RED("infiniteloop")] public inkanimPlaybackOptions Infiniteloop { get; set; }

		public sampleTextScrolling(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
