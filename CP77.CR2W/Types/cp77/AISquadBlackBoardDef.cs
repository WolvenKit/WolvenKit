using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AISquadBlackBoardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("BarkPlayed")] public gamebbScriptID_Bool BarkPlayed { get; set; }
		[Ordinal(1)] [RED("LowHealthBarkPlayed")] public gamebbScriptID_Bool LowHealthBarkPlayed { get; set; }
		[Ordinal(2)] [RED("BarkPlayedTimeStamp")] public gamebbScriptID_Float BarkPlayedTimeStamp { get; set; }

		public AISquadBlackBoardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
