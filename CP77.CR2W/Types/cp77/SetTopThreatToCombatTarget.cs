using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetTopThreatToCombatTarget : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("movePoliciesComponent")] public CHandle<movePoliciesComponent> MovePoliciesComponent { get; set; }
		[Ordinal(1)]  [RED("previousChecktime")] public CFloat PreviousChecktime { get; set; }
		[Ordinal(2)]  [RED("refreshTimer")] public CFloat RefreshTimer { get; set; }
		[Ordinal(3)]  [RED("targetChangeTime")] public CFloat TargetChangeTime { get; set; }
		[Ordinal(4)]  [RED("targetTrackerComponent")] public CHandle<TargetTrackingExtension> TargetTrackerComponent { get; set; }

		public SetTopThreatToCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
