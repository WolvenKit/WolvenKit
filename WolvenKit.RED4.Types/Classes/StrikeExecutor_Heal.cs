using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StrikeExecutor_Heal : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("healthPerc")] 
		public CFloat HealthPerc
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
