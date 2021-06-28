using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_FootPhaseEvent : animIAnimStateTransitionCondition
	{
		private CEnum<animEFootPhase> _footPhase;

		[Ordinal(0)] 
		[RED("footPhase")] 
		public CEnum<animEFootPhase> FootPhase
		{
			get => GetProperty(ref _footPhase);
			set => SetProperty(ref _footPhase, value);
		}

		public animAnimStateTransitionCondition_FootPhaseEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
