using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questRecordingNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("type")] public CHandle<questIRecordingNodeType> Type { get; set; }

		public questRecordingNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
