using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckWoundedStatusEffectState : AIStatusEffectCondition
	{
		private CEnum<EstatusEffectsState> _stateToCheck;

		[Ordinal(0)] 
		[RED("stateToCheck")] 
		public CEnum<EstatusEffectsState> StateToCheck
		{
			get => GetProperty(ref _stateToCheck);
			set => SetProperty(ref _stateToCheck, value);
		}

		public CheckWoundedStatusEffectState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
