using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScoreboardPlayer : CVariable
	{
		[Ordinal(0)]  [RED("playerName")] public CString PlayerName { get; set; }
		[Ordinal(1)]  [RED("playerScore")] public CInt32 PlayerScore { get; set; }

		public ScoreboardPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
