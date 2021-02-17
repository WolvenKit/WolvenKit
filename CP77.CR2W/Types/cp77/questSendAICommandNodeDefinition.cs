using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSendAICommandNodeDefinition : questAICommandNodeBase
	{
		[Ordinal(2)] [RED("puppet")] public gameEntityReference Puppet { get; set; }
		[Ordinal(3)] [RED("commandParams")] public CHandle<questAICommandParams> CommandParams { get; set; }

		public questSendAICommandNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
