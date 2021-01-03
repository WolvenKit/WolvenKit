using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OnReserveWorkspotEvent : OnWorkspotAvailabilityEvent
	{
		[Ordinal(0)]  [RED("action")] public CEnum<gamedataWorkspotActionType> Action { get; set; }

		public OnReserveWorkspotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
