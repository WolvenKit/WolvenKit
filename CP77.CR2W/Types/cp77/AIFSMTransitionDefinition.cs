using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIFSMTransitionDefinition : CVariable
	{
		[Ordinal(0)]  [RED("condition")] public CUInt16 Condition { get; set; }
		[Ordinal(1)]  [RED("destination")] public CUInt16 Destination { get; set; }

		public AIFSMTransitionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
