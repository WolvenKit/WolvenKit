using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questUnequipItemNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(1)]  [RED("params")] public questUnequipItemParams Params { get; set; }

		public questUnequipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
