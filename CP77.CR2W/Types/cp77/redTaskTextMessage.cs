using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class redTaskTextMessage : CVariable
	{
		[Ordinal(0)] [RED("taskId")] public CUInt32 TaskId { get; set; }
		[Ordinal(1)] [RED("text")] public CString Text { get; set; }
		[Ordinal(2)] [RED("type")] public CEnum<redTaskTextMessageType> Type { get; set; }

		public redTaskTextMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
