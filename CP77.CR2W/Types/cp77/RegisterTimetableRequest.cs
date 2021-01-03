using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RegisterTimetableRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("lights")] public CInt32 Lights { get; set; }
		[Ordinal(1)]  [RED("requesterData")] public PSOwnerData RequesterData { get; set; }
		[Ordinal(2)]  [RED("timeTable")] public CArray<SDeviceTimetableEntry> TimeTable { get; set; }

		public RegisterTimetableRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
