using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckWoundedStatusEffectState : AIStatusEffectCondition
	{
		[Ordinal(0)] [RED("stateToCheck")] public CEnum<EstatusEffectsState> StateToCheck { get; set; }

		public CheckWoundedStatusEffectState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
