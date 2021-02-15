using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkTutorialOverlayInputRequest : redEvent
	{
		[Ordinal(0)] [RED("isInputRequested")] public CBool IsInputRequested { get; set; }

		public inkTutorialOverlayInputRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
