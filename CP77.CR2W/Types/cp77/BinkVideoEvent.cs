using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BinkVideoEvent : redEvent
	{
		[Ordinal(0)]  [RED("path")] public redResourceReferenceScriptToken Path { get; set; }
		[Ordinal(1)]  [RED("startingTime")] public CFloat StartingTime { get; set; }
		[Ordinal(2)]  [RED("shouldPlay")] public CBool ShouldPlay { get; set; }

		public BinkVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
