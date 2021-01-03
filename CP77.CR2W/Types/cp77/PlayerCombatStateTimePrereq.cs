using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerCombatStateTimePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("maxTime")] public CFloat MaxTime { get; set; }
		[Ordinal(1)]  [RED("minTime")] public CFloat MinTime { get; set; }

		public PlayerCombatStateTimePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
