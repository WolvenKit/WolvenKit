using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questShowWorldNode_NodeType : questIWorldDataManagerNodeType
	{
		[Ordinal(0)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(1)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)]  [RED("show")] public CBool Show { get; set; }
		[Ordinal(3)]  [RED("componentName")] public CName ComponentName { get; set; }

		public questShowWorldNode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
