using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMovePuppetNodeDefinition : questConfigurableAICommandNode
	{
		[Ordinal(2)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(3)] [RED("moveType")] public CName MoveType { get; set; }
		[Ordinal(4)] [RED("nodeParams")] public CHandle<questAICommandParams> NodeParams { get; set; }

		public questMovePuppetNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
