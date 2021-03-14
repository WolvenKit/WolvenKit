using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestDeviceWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		[Ordinal(2)] [RED("requesters")] public CArray<gamePersistentID> Requesters { get; set; }

		public RequestDeviceWidgetsUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
