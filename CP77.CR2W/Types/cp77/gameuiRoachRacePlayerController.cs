using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRacePlayerController : gameuiSideScrollerMiniGamePlayerController
	{
		[Ordinal(0)]  [RED("runAnimation")] public CName RunAnimation { get; set; }
		[Ordinal(1)]  [RED("jumpAnimation")] public CName JumpAnimation { get; set; }
		[Ordinal(2)]  [RED("currentAnimation")] public CHandle<inkanimProxy> CurrentAnimation { get; set; }

		public gameuiRoachRacePlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
