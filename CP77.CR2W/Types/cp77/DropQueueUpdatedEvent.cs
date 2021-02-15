using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DropQueueUpdatedEvent : redEvent
	{
		[Ordinal(0)] [RED("dropQueue")] public CArray<gameItemModParams> DropQueue { get; set; }

		public DropQueueUpdatedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
