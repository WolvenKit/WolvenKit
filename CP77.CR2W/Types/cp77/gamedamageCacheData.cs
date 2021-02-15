using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedamageCacheData : IScriptable
	{
		[Ordinal(0)] [RED("targetImmortalityMode")] public CEnum<gameGodModeType> TargetImmortalityMode { get; set; }
		[Ordinal(1)] [RED("TEMP_ImmortalityCached")] public CBool TEMP_ImmortalityCached { get; set; }
		[Ordinal(2)] [RED("logFlags")] public CInt64 LogFlags { get; set; }

		public gamedamageCacheData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
