using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SendScoreRequestAdvanced : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("gameState")] public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState { get; set; }
		[Ordinal(1)]  [RED("gameName")] public CString GameName { get; set; }

		public SendScoreRequestAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
