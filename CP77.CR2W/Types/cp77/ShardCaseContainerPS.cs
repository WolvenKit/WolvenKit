using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShardCaseContainerPS : gameLootContainerBasePS
	{
		[Ordinal(0)]  [RED("markAsQuest")] public CBool MarkAsQuest { get; set; }
		[Ordinal(1)]  [RED("isDisabled")] public CBool IsDisabled { get; set; }
		[Ordinal(2)]  [RED("isLocked")] public CBool IsLocked { get; set; }

		public ShardCaseContainerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
