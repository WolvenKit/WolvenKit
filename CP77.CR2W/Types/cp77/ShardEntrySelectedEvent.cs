using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShardEntrySelectedEvent : redEvent
	{
		[Ordinal(0)] [RED("hash")] public CUInt32 Hash { get; set; }

		public ShardEntrySelectedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
