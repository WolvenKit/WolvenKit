using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetPhaseState : AIActionHelperTask
	{
		private CEnum<ENPCPhaseState> _phaseStateValue;

		[Ordinal(5)] 
		[RED("phaseStateValue")] 
		public CEnum<ENPCPhaseState> PhaseStateValue
		{
			get => GetProperty(ref _phaseStateValue);
			set => SetProperty(ref _phaseStateValue, value);
		}

		public SetPhaseState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
