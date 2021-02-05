using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitIsTheSameTargetPrereqState : GenericHitPrereqState
	{
		[Ordinal(0)]  [RED("listener")] public CHandle<HitCallback> Listener { get; set; }
		[Ordinal(1)]  [RED("hitEvent")] public CHandle<gameeventsHitEvent> HitEvent { get; set; }
		[Ordinal(2)]  [RED("previousTarget")] public wCHandle<gameObject> PreviousTarget { get; set; }
		[Ordinal(3)]  [RED("previousSource")] public wCHandle<gameObject> PreviousSource { get; set; }
		[Ordinal(4)]  [RED("previousWeapon")] public wCHandle<gameweaponObject> PreviousWeapon { get; set; }

		public HitIsTheSameTargetPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
