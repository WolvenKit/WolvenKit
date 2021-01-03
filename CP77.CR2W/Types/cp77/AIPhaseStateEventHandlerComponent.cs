using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIPhaseStateEventHandlerComponent : AIRelatedComponents
	{
		[Ordinal(0)]  [RED("phaseStateValue")] public CEnum<ENPCPhaseState> PhaseStateValue { get; set; }

		public AIPhaseStateEventHandlerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
