using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExhaustedEvents : StaminaEventsTransition
	{
		[Ordinal(1)] 
		[RED("staminaVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> StaminaVfxBlackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}
	}
}
