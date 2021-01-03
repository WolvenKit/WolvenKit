using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AISquadBlackBoardDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("BarkPlayed")] public gamebbScriptID_Bool BarkPlayed { get; set; }
		[Ordinal(1)]  [RED("BarkPlayedTimeStamp")] public gamebbScriptID_Float BarkPlayedTimeStamp { get; set; }
		[Ordinal(2)]  [RED("LowHealthBarkPlayed")] public gamebbScriptID_Bool LowHealthBarkPlayed { get; set; }

		public AISquadBlackBoardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
