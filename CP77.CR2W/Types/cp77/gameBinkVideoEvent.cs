using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameBinkVideoEvent : redEvent
	{
		[Ordinal(0)] [RED("videoPath")] public CString VideoPath { get; set; }
		[Ordinal(1)] [RED("action")] public CEnum<gameBinkVideoAction> Action { get; set; }

		public gameBinkVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
