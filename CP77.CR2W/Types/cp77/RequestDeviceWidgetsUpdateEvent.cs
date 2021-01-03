using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RequestDeviceWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		[Ordinal(0)]  [RED("requesters")] public CArray<gamePersistentID> Requesters { get; set; }

		public RequestDeviceWidgetsUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
