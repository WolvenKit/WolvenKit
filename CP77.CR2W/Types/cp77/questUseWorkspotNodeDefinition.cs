using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questUseWorkspotNodeDefinition : questAICommandNodeBase
	{
		[Ordinal(2)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(3)] [RED("paramsV1")] public CHandle<questUseWorkspotParamsV1> ParamsV1 { get; set; }

		public questUseWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
