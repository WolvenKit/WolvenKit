using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questMiscAICommandNode : questConfigurableAICommandNode
	{
		[Ordinal(2)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(3)] [RED("function")] public CName Function { get; set; }
		[Ordinal(4)] [RED("params")] public CHandle<questAICommandParams> Params { get; set; }

		public questMiscAICommandNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
