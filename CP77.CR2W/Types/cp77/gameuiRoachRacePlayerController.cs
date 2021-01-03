using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRacePlayerController : gameuiSideScrollerMiniGamePlayerController
	{
		[Ordinal(0)]  [RED("currentAnimation")] public CHandle<inkanimProxy> CurrentAnimation { get; set; }
		[Ordinal(1)]  [RED("jumpAnimation")] public CName JumpAnimation { get; set; }
		[Ordinal(2)]  [RED("runAnimation")] public CName RunAnimation { get; set; }

		public gameuiRoachRacePlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
