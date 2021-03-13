using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameState : IScriptable
	{
		[Ordinal(0)] [RED("currentLives")] public CInt32 CurrentLives { get; set; }
		[Ordinal(1)] [RED("currentScore")] public CInt32 CurrentScore { get; set; }

		public gameuiMinigameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
