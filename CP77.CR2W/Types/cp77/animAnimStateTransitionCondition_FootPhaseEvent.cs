using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_FootPhaseEvent : animIAnimStateTransitionCondition
	{
		[Ordinal(0)]  [RED("footPhase")] public CEnum<animEFootPhase> FootPhase { get; set; }

		public animAnimStateTransitionCondition_FootPhaseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
