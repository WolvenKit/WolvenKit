using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questStartRecording_NodeType : questIRecordingNodeType
	{
		[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)] [RED("sectionName")] public CString SectionName { get; set; }

		public questStartRecording_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
