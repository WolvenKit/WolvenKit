using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questStartRecording_NodeType : questIRecordingNodeType
	{
		[Ordinal(0)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)]  [RED("sectionName")] public CString SectionName { get; set; }

		public questStartRecording_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
