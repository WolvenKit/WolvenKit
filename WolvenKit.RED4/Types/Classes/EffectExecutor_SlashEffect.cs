using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectExecutor_SlashEffect : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<EffectExecutor_SlashEffect_Entry> Entries
		{
			get => GetPropertyValue<CArray<EffectExecutor_SlashEffect_Entry>>();
			set => SetPropertyValue<CArray<EffectExecutor_SlashEffect_Entry>>(value);
		}

		public EffectExecutor_SlashEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
