using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerAIDirectorNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("params")] public CHandle<questMultiplayerAIDirectorParams> Params { get; set; }

		public questMultiplayerAIDirectorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
