using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StrikeExecutor_Heal : gameEffectExecutor_Scripted
	{
		private CFloat _healthPerc;

		[Ordinal(1)] 
		[RED("healthPerc")] 
		public CFloat HealthPerc
		{
			get => GetProperty(ref _healthPerc);
			set => SetProperty(ref _healthPerc, value);
		}
	}
}
