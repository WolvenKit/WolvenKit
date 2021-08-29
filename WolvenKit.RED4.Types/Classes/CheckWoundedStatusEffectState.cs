using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckWoundedStatusEffectState : AIStatusEffectCondition
	{
		private CEnum<EstatusEffectsState> _stateToCheck;

		[Ordinal(0)] 
		[RED("stateToCheck")] 
		public CEnum<EstatusEffectsState> StateToCheck
		{
			get => GetProperty(ref _stateToCheck);
			set => SetProperty(ref _stateToCheck, value);
		}
	}
}
