using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamedamageCacheData : IScriptable
	{
		[Ordinal(0)]  [RED("TEMP_ImmortalityCached")] public CBool TEMP_ImmortalityCached { get; set; }
		[Ordinal(1)]  [RED("logFlags")] public CInt64 LogFlags { get; set; }
		[Ordinal(2)]  [RED("targetImmortalityMode")] public CEnum<gameGodModeType> TargetImmortalityMode { get; set; }

		public gamedamageCacheData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
