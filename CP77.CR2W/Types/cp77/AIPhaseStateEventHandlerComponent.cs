using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIPhaseStateEventHandlerComponent : AIRelatedComponents
	{
		[Ordinal(5)] [RED("phaseStateValue")] public CEnum<ENPCPhaseState> PhaseStateValue { get; set; }

		public AIPhaseStateEventHandlerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
