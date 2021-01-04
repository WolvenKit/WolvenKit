using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TimeTableCallbackRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("callBackID")] public CUInt32 CallBackID { get; set; }

		public TimeTableCallbackRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
