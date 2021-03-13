using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShardEntryData : GenericCodexEntryData
	{
		[Ordinal(10)] [RED("isCrypted")] public CBool IsCrypted { get; set; }

		public ShardEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
