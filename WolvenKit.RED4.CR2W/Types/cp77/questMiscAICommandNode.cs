using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
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
