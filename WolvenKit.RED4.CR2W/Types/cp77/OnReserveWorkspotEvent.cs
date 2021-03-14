using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnReserveWorkspotEvent : OnWorkspotAvailabilityEvent
	{
		[Ordinal(1)] [RED("action")] public CEnum<gamedataWorkspotActionType> Action { get; set; }

		public OnReserveWorkspotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
