using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionBossDataDef : AIBlackboardDef
	{
		[Ordinal(0)] [RED("excludedWaypointPosition")] public gamebbScriptID_Variant ExcludedWaypointPosition { get; set; }

		public AIActionBossDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
