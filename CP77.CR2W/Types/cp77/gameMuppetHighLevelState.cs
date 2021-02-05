using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetHighLevelState : CVariable
	{
		[Ordinal(0)]  [RED("isDead")] public CBool IsDead { get; set; }
		[Ordinal(1)]  [RED("deathFrameId")] public CUInt32 DeathFrameId { get; set; }

		public gameMuppetHighLevelState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
