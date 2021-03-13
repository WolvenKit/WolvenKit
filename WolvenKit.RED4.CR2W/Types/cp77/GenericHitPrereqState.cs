using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericHitPrereqState : gamePrereqState
	{
		[Ordinal(0)] [RED("listener")] public CHandle<HitCallback> Listener { get; set; }
		[Ordinal(1)] [RED("hitEvent")] public CHandle<gameeventsHitEvent> HitEvent { get; set; }

		public GenericHitPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
