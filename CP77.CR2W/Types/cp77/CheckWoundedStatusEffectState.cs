using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CheckWoundedStatusEffectState : AIStatusEffectCondition
	{
		[Ordinal(0)]  [RED("stateToCheck")] public CEnum<EstatusEffectsState> StateToCheck { get; set; }

		public CheckWoundedStatusEffectState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
