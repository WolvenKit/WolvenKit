using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMuppetHighLevelState : CVariable
	{
		[Ordinal(0)]  [RED("deathFrameId")] public CUInt32 DeathFrameId { get; set; }
		[Ordinal(1)]  [RED("isDead")] public CBool IsDead { get; set; }

		public gameMuppetHighLevelState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
