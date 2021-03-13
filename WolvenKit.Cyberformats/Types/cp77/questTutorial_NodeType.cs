using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTutorial_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("subtype")] public CHandle<questITutorial_NodeSubType> Subtype { get; set; }

		public questTutorial_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
