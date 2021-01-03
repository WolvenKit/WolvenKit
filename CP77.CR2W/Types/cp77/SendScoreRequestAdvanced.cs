using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SendScoreRequestAdvanced : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("gameName")] public CString GameName { get; set; }
		[Ordinal(1)]  [RED("gameState")] public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState { get; set; }

		public SendScoreRequestAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
