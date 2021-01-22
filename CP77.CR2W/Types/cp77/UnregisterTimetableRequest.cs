using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UnregisterTimetableRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("requesterData")] public PSOwnerData RequesterData { get; set; }

		public UnregisterTimetableRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
