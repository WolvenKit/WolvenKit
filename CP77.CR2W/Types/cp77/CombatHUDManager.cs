using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CombatHUDManager : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("interval")] public CFloat Interval { get; set; }
		[Ordinal(1)]  [RED("isRunning")] public CBool IsRunning { get; set; }
		[Ordinal(2)]  [RED("targets")] public CArray<CombatTarget> Targets { get; set; }
		[Ordinal(3)]  [RED("timeSinceLastUpdate")] public CFloat TimeSinceLastUpdate { get; set; }

		public CombatHUDManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
