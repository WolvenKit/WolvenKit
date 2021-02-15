using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameScanningLookAtEvent : redEvent
	{
		[Ordinal(0)] [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(1)] [RED("state")] public CBool State { get; set; }

		public gameScanningLookAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
