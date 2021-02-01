using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RequestBreadCrumbBarUpdateEvent : redEvent
	{
		[Ordinal(0)]  [RED("breadCrumbData")] public SBreadCrumbUpdateData BreadCrumbData { get; set; }
		[Ordinal(1)]  [RED("requester")] public gamePersistentID Requester { get; set; }

		public RequestBreadCrumbBarUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
