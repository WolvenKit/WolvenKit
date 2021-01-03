using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameState : IScriptable
	{
		[Ordinal(0)]  [RED("currentLives")] public CInt32 CurrentLives { get; set; }
		[Ordinal(1)]  [RED("currentScore")] public CInt32 CurrentScore { get; set; }

		public gameuiMinigameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
