using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameDynamicEventNode : worldAreaShapeNode
	{
		[Ordinal(4)] [RED("mappinRef")] public NodeRef MappinRef { get; set; }
		[Ordinal(5)] [RED("condition")] public CHandle<questIBaseCondition> Condition { get; set; }

		public gameDynamicEventNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
