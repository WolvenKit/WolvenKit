using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questShowWorldNode_NodeType : questIWorldDataManagerNodeType
	{
		[Ordinal(0)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(1)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(3)]  [RED("show")] public CBool Show { get; set; }

		public questShowWorldNode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
