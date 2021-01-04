using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class linkedClueTagEvent : redEvent
	{
		[Ordinal(0)]  [RED("requesterID")] public entEntityID RequesterID { get; set; }
		[Ordinal(1)]  [RED("tag")] public CBool Tag { get; set; }

		public linkedClueTagEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
