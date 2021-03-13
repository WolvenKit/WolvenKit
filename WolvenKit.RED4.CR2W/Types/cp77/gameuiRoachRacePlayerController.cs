using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRacePlayerController : gameuiSideScrollerMiniGamePlayerController
	{
		[Ordinal(1)] [RED("runAnimation")] public CName RunAnimation { get; set; }
		[Ordinal(2)] [RED("jumpAnimation")] public CName JumpAnimation { get; set; }
		[Ordinal(3)] [RED("currentAnimation")] public CHandle<inkanimProxy> CurrentAnimation { get; set; }

		public gameuiRoachRacePlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
