using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameDynamicEventNode : worldAreaShapeNode
	{
		[Ordinal(0)]  [RED("condition")] public CHandle<questIBaseCondition> Condition { get; set; }
		[Ordinal(1)]  [RED("mappinRef")] public NodeRef MappinRef { get; set; }

		public gameDynamicEventNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
