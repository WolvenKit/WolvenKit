using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFSMTransitionDefinition : CVariable
	{
		[Ordinal(0)]  [RED("destination")] public CUInt16 Destination { get; set; }
		[Ordinal(1)]  [RED("condition")] public CUInt16 Condition { get; set; }

		public AIFSMTransitionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
