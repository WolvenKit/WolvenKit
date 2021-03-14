using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTeleportPuppetNodeDefinition : questAICommandNodeBase
	{
		[Ordinal(2)] [RED("entityReference")] public CHandle<questUniversalRef> EntityReference { get; set; }
		[Ordinal(3)] [RED("params")] public CHandle<questTeleportPuppetParamsV1> Params { get; set; }

		public questTeleportPuppetNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
