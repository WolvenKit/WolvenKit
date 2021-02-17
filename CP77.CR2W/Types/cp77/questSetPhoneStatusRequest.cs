using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetPhoneStatusRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("status")] public CName Status { get; set; }

		public questSetPhoneStatusRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
