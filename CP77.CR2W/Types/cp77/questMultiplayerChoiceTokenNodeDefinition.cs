using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerChoiceTokenNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("params")] public questMultiplayerChoiceTokenParams Params { get; set; }

		public questMultiplayerChoiceTokenNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
