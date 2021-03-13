using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetPhaseState : AIActionHelperTask
	{
		[Ordinal(5)] [RED("phaseStateValue")] public CEnum<ENPCPhaseState> PhaseStateValue { get; set; }

		public SetPhaseState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
