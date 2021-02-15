using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NewCodexEntryUserData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("data")] public CString Data { get; set; }

		public NewCodexEntryUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
