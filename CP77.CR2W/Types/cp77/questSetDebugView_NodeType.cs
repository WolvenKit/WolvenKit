using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetDebugView_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] [RED("mode")] public CEnum<questEDebugViewMode> Mode { get; set; }

		public questSetDebugView_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
