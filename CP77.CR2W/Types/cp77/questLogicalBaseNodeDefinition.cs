using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questLogicalBaseNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("inputSocketCount")] public CUInt32 InputSocketCount { get; set; }
		[Ordinal(1)]  [RED("outputSocketCount")] public CUInt32 OutputSocketCount { get; set; }

		public questLogicalBaseNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
