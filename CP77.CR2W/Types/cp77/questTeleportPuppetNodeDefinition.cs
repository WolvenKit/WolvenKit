using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questTeleportPuppetNodeDefinition : questAICommandNodeBase
	{
		[Ordinal(0)]  [RED("entityReference")] public CHandle<questUniversalRef> EntityReference { get; set; }
		[Ordinal(1)]  [RED("params")] public CHandle<questTeleportPuppetParamsV1> Params { get; set; }

		public questTeleportPuppetNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
