using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeExtendableNodeDefinition : AICTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("optionalChild")] public CHandle<LibTreeINodeDefinition> OptionalChild { get; set; }

		public AICTreeExtendableNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
