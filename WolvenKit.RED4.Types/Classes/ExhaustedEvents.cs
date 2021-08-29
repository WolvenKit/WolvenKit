using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExhaustedEvents : StaminaEventsTransition
	{
		private CHandle<worldEffectBlackboard> _staminaVfxBlackboard;

		[Ordinal(1)] 
		[RED("staminaVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> StaminaVfxBlackboard
		{
			get => GetProperty(ref _staminaVfxBlackboard);
			set => SetProperty(ref _staminaVfxBlackboard, value);
		}
	}
}
