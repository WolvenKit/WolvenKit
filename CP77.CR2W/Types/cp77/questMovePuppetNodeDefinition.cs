using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questMovePuppetNodeDefinition : questConfigurableAICommandNode
	{
		[Ordinal(0)]  [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(1)]  [RED("moveType")] public CName MoveType { get; set; }
		[Ordinal(2)]  [RED("nodeParams")] public CHandle<questAICommandParams> NodeParams { get; set; }

		public questMovePuppetNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
