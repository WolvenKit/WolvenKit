using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EventsFilters : CVariable
	{
		[Ordinal(0)]  [RED("incomingEventsFilter")] public CEnum<EFilterType> IncomingEventsFilter { get; set; }
		[Ordinal(1)]  [RED("outgoingEventsFilter")] public CEnum<EFilterType> OutgoingEventsFilter { get; set; }

		public EventsFilters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
