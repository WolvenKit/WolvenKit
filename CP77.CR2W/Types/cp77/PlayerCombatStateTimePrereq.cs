using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerCombatStateTimePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("minTime")] public CFloat MinTime { get; set; }
		[Ordinal(1)] [RED("maxTime")] public CFloat MaxTime { get; set; }

		public PlayerCombatStateTimePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
