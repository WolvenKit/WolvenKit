using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetConveyorState_NodeType : questIInteractiveObjectManagerNodeType
	{
		[Ordinal(0)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }

		public questSetConveyorState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
